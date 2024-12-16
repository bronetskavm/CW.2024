using course_DB.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace course_DB
{
    public partial class Frm_StorageUpdate : Form
    {
        Frm_Storages frm_Storages;
        public Frm_StorageUpdate(Frm_Storages frm_Storages)
        {
            InitializeComponent();
            this.frm_Storages = frm_Storages;
        }

        private void button2_Click(object sender, EventArgs e) // search
        {
            bool check = true;
            for (int i = 0; i < Databank.storages.Count; i++)
            {
                if (tBox_Id.Text == Databank.storages[i].Id.ToString())
                {
                    tBox_Name.Text = Databank.storages[i].Name;
                    tBox_Number.Text = Convert.ToString(Databank.storages[i].Number);
                    tBox_Price.Text = Convert.ToString(Databank.storages[i].Price);
                    tBox_ExpDate.Text = Databank.storages[i].ExpirationDate;
                    tBox_ProvId.Text = Convert.ToString(Databank.storages[i].ProviderId);
                    tBox_DelivId.Text = Convert.ToString(Databank.storages[i].DeliveryId);
                    check = false;
                    break;
                }
            }
            if (check)
            {
                MessageBox.Show("Не вірно вказано ID!");
            }
        }

        private void button1_Click(object sender, EventArgs e) // update
        {
            string sql = "";
            bool check = true;
            SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);

            bool good = false;
            for (int i = 0; i < Databank.storages.Count; i++)
            {
                if (tBox_Id.Text == Databank.storages[i].Id.ToString())
                {
                    good = true; break;
                }
            }
            if (!good)
            {
                MessageBox.Show("Не вірно вказано ID!");
            }

            if (check)
            {
                if ((tBox_Id.Text == "") || (tBox_Name.Text == "") || (tBox_Number.Text == "") || (tBox_Price.Text == "") || (tBox_ExpDate.Text == "") || (tBox_ProvId.Text == "") || (tBox_DelivId.Text == ""))
                {
                    check = false;
                    MessageBox.Show("Некоректно заповненні поля!");
                }
            }

            if (check)
            {
                double allprice = Convert.ToDouble(tBox_Number.Text) * Convert.ToDouble(tBox_Price.Text);
                sql = $"update Storage set ID = '{tBox_Id.Text}', Name = '{tBox_Name.Text}', Number = '{tBox_Number.Text}', [Price/Piece] = '{tBox_Price.Text}', AllPrice = '{allprice}', ExpirationDate = '{tBox_ExpDate.Text}', ProviderID = '{tBox_ProvId.Text}', DeliveryID = '{tBox_DelivId.Text}' where ID = '{tBox_Id.Text}'";
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Дія пройшла успішно!");
            }

            frm_Storages.UpdateDate();
            this.Hide();
        }
    }
}
