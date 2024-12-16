using course_DB.Classes;
using System.Data;
using System.Data.SQLite;
using System.Net.Sockets;
using static System.Net.Mime.MediaTypeNames;

namespace course_DB
{
    public partial class Frm_Main : Form
    {
#pragma warning disable CS0414 // The field 'Frm_Main.sql' is assigned but its value is never used
        string sql = "";
#pragma warning restore CS0414 // The field 'Frm_Main.sql' is assigned but its value is never used

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Databank.m_dbConnection = new SQLiteConnection(@"Data Source=C:\Users\illya\OneDrive\Desktop\курсач\course_DB\Database\StoreAccount.db;Version=3;");
            Databank.m_dbConnection.Open();
            Databank.SelectAccounts();
            Frm_LogIn frm_LogIn = new Frm_LogIn(this);
            frm_LogIn.Show();
        }

        private void btn_AddItems_Click(object sender, EventArgs e)
        {
            Frm_AddItems frm_AddItems = new Frm_AddItems(this);
            frm_AddItems.Show();
        }

        private void btn_UpdateItems_Click(object sender, EventArgs e)
        {
            Frm_MainTableUpdate frm = new Frm_MainTableUpdate(this);
            frm.Show();
        }

        private void btn_CreateReceipt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Пуста таблиця!");
            }
            else
            {
                DateTime now = DateTime.Now;
                string path = @$"C:\Users\illya\OneDrive\Desktop\курсач\course_DB\Receipt\{now.Day}.{now.Month}.{now.Year}-{now.Hour}г {now.Minute}м.txt";
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.WriteLine("Чек виданий - " + lb_Position.Text + " " + lb_Name.Text + "\n");
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        sw.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.ColumnCount - 1)
                            sw.Write("\t");
                    }
                    sw.WriteLine();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            sw.Write(dataGridView1.Rows[i].Cells[j].Value);
                            if (j < dataGridView1.Columns.Count - 1)
                                sw.Write("\t");
                        }
                        sw.WriteLine();
                    }
                    sw.WriteLine("\nКінцева сума: " + FinallyPrice.Text + " грн.");
                }

                for (int i = 0; i < Databank.tableMains.Count; i++)
                {
                    Databank.addItemsToZvits(Databank.tableMains[i].Id, Databank.tableMains[i].Name, Databank.tableMains[i].Number, Databank.tableMains[i].Price, Databank.AccountIdNow);
                    Databank.DeleteItemsAfterSellInStorage(Databank.tableMains[i].Id, Databank.tableMains[i].Number);
                }

                FinallyPrice.Text = "";
                dataGridView1.DataSource = null;
                MessageBox.Show("Чек зроблено!");
            }
        }

        private void відкритиТаблицюПостачальниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Databank.AccPosition == "Бухгалтер") || (Databank.AccPosition == "Адміністратор"))
            {
                Frm_Providers frm_Providers = new Frm_Providers();
                frm_Providers.Show();
            }
            else
            {
                MessageBox.Show("У вас немає доступу!");
            }
        }

        private void btn_StartScaner_Click(object sender, EventArgs e)
        {
            Frm_Deliverys frm_Deliverys = new Frm_Deliverys();
            Frm_Scaner frm_Scaner = new Frm_Scaner(this, frm_Deliverys, true);
            frm_Scaner.Show();
        }

        private void відкритиТаблицюПоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Databank.AccPosition == "Бухгалтер") || (Databank.AccPosition == "Адміністратор"))
            {
                Frm_Deliverys frm_Deliverys = new Frm_Deliverys();
                frm_Deliverys.Show();
            }
            else
            {
                MessageBox.Show("У вас немає доступу!");
            }
        }

        private void відкритиТаблицюСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Databank.AccPosition != "Бухгалтер")
            {
                Frm_Storages frm = new Frm_Storages();
                frm.Show();
            }
            else
            {
                MessageBox.Show("У вас немає доступу!");
            }
        }

        private void відкритиТаблицюЗвітиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Databank.AccPosition == "Бухгалтер") || (Databank.AccPosition == "Адміністратор"))
            {
                Frm_Zvits frm = new Frm_Zvits();
                frm.Show();
            }
            else
            {
                MessageBox.Show("У вас немає доступу!");
            }
        }

        private void відкритиТаблицюСтасистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Databank.AccPosition == "Адміністратор")
            {
                Frm_AllZvitsStatics frm = new Frm_AllZvitsStatics();
                frm.Show();
            }
            else
            {
                MessageBox.Show("У вас немає доступу!");
            }
        }

        private void lb_AllPrice_Click(object sender, EventArgs e)
        {

        }
    }
}