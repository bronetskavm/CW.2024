using AForge.Video;
using AForge.Video.DirectShow;
using course_DB.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace course_DB
{
    public partial class Frm_Scaner : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        Frm_Main frm_Main;
        Frm_Deliverys frm_Deliverys;
        bool IsSell;
        public Frm_Scaner(Frm_Main frm_Main, Frm_Deliverys frm_Deliverys, bool isSell)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            this.frm_Main = frm_Main;
            this.frm_Deliverys = frm_Deliverys;
            this.IsSell = isSell;
        }

        private void Frm_Scaner_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }

            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            Databank.SelectStorage();
        }

        private void btn_StopScan_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
            }
            timer1.Stop();
            this.Hide();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_StartScan_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox.Image);

            bool isItems = false;
            int id_storage;
            try
            {
                if (result == null) { return; }
                string decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    id_storage = 0;
                    timer1.Stop();

                    for (int i = 0; i < Databank.storages.Count; i++)
                    {
                        if (decoded == Databank.storages[i].Id)
                        {
                            isItems = true;
                            id_storage = i;
                            break;
                        }
                    }

                    if (!IsSell)
                    {
                        if (isItems)
                        {
                            MessageBox.Show("Дане ID вже існує у базі!");
                        }
                        else
                        {
                            MessageBox.Show("Товар збережено!");
                            Databank.BufferItemsForDecoded = decoded;
                            Frm_DelivAddItems frm_add = new Frm_DelivAddItems(frm_Deliverys, false);
                            frm_add.Show();
                        }
                    }
                    else
                    {
                        if (!isItems)
                        {
                            MessageBox.Show("ID is not exist: " + decoded);
                        }
                        else
                        {
                            MessageBox.Show("Товар збережено!");
                            if (IsSell)
                            {
                                Databank.tableInput(frm_Main, id_storage, decoded);
                            }
                            else
                            {

                            }
                        }
                    }

                    timer1.Start();
                    timer1_Tick(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ChangeCamera_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
