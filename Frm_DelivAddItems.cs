using course_DB.Classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_DB
{
    public partial class Frm_DelivAddItems : Form
    {
        DateTime nowDataArrive = DateTime.Now;
        bool Update;
        Frm_Deliverys frm_Deliverys;
        public Frm_DelivAddItems(Frm_Deliverys Frm_Deliverys, bool update)
        {
            InitializeComponent();
            tBox_ProdId.Text = Databank.BufferItemsForDecoded;
            tBox_ID.Text = (Databank.Deliverys.Count + 1).ToString();
            Update = update;
            frm_Deliverys = Frm_Deliverys;
            if (!Update)
            {
                tBox_Arrival.Text = $"{nowDataArrive.Day}.{nowDataArrive.Month}.{nowDataArrive.Year}";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string sql = "";
            bool check = true;
            SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);

            for (int i = 0; i < Databank.Deliverys.Count; i++)
            {
                if ((tBox_ID.Text == Databank.Deliverys[i].Id.ToString()) && (Update == false))
                {
                    MessageBox.Show("Це ID вже використовується!");
                    check = false; break;
                }
            }

            if (Update)
            {
                bool good = false;
                for (int i = 0; i < Databank.Deliverys.Count; i++)
                {
                    if (tBox_ID.Text == Databank.Deliverys[i].Id.ToString())
                    {
                        good = true; break;
                    }
                }
                if (!good)
                {
                    MessageBox.Show("Не вірно вказано ID!");
                }
            }

            if (check)
            {
                if ((tBox_ID.Text == "") || (tBox_Name.Text == "") || (tBox_Arrival.Text == "") || (tBox_Number.Text == "") || (tBox_Price.Text == "") || (tBox_ProdId.Text == "") || (tBox_ProvId.Text == ""))
                {
                    check = false;
                    MessageBox.Show("Некоректно заповненні поля!");
                }
            }

            double allPrice = Convert.ToDouble(tBox_Number.Text) * Convert.ToDouble(tBox_Price.Text);
            if ((check) && (!Update))
            {
                sql = "insert into Deliverys (ID, ProductID, NameProduct, Numbers, [Price/Piece], PriceAll, Arrival, ProviderID) VALUES (" + tBox_ID.Text + ", '" + tBox_ProdId.Text + "', '" + tBox_Name.Text + "'," + tBox_Number.Text + ", " + tBox_Price.Text + ", " + allPrice + ", '" + tBox_Arrival.Text + "', " + tBox_ProvId.Text + ")";
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
                Databank.addItemsToDelivTable(Convert.ToInt32(tBox_ID.Text), tBox_ProdId.Text, tBox_Name.Text, Convert.ToInt32(tBox_Number.Text), Convert.ToDouble(tBox_Price.Text), tBox_Arrival.Text, Convert.ToInt32(tBox_ProvId.Text));
                Databank.addItemsToStorageTable(tBox_ProdId.Text, tBox_Name.Text, Convert.ToInt32(tBox_Number.Text), Convert.ToDouble(tBox_Price.Text), "не вказано", Convert.ToInt32(tBox_ProvId.Text), Convert.ToInt32(tBox_ID.Text), false);
                MessageBox.Show("Дія пройшла успішно!");
            }
            else if ((check) && (Update))
            {
                sql = "update Deliverys set ID = " + tBox_ID.Text + ", ProductID = '" + tBox_ProdId.Text + "', Numbers = '" + tBox_Number.Text + "', [Price/Piece] = '" + tBox_Price.Text + "', PriceAll = '" + allPrice + "', Arrival = '" + tBox_Arrival.Text + "', ProviderID = '" + tBox_ProvId.Text + "' where ID = " + tBox_ID.Text;
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
                Databank.addItemsToDelivTable(Convert.ToInt32(tBox_ID.Text), tBox_ProdId.Text, tBox_Name.Text, Convert.ToInt32(tBox_Number.Text), Convert.ToDouble(tBox_Price.Text), tBox_Arrival.Text, Convert.ToInt32(tBox_ProvId.Text));
                Databank.addItemsToStorageTable(tBox_ProdId.Text, tBox_Name.Text, Convert.ToInt32(tBox_Number.Text), Convert.ToDouble(tBox_Price.Text), "не вказано", Convert.ToInt32(tBox_ProvId.Text), Convert.ToInt32(tBox_ID.Text), true);
                MessageBox.Show("Дія пройшла успішно!");
            }

            frm_Deliverys.UpdateDate();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //seach for ID product
        {
            bool check = true;
            for (int i = 0; i < Databank.Deliverys.Count; i++)
            {
                if (tBox_ID.Text == Databank.Deliverys[i].Id.ToString())
                {
                    tBox_ProdId.Text = Databank.Deliverys[i].ProductID.ToString();
                    tBox_Name.Text = Databank.Deliverys[i].NameProduct;
                    tBox_Number.Text = Databank.Deliverys[i].Numbers.ToString();
                    tBox_Price.Text = Databank.Deliverys[i].PricePiece.ToString();
                    tBox_Arrival.Text = Databank.Deliverys[i].Arrival;
                    tBox_ProvId.Text = Databank.Deliverys[i].ProviderId.ToString();
                    check = false;
                    break;
                }
            }
            if (check)
            {
                MessageBox.Show("Не вірно вказано ID товару!");
            }
        }

        private void Frm_DelivAddItems_Load(object sender, EventArgs e)
        {
            if (Update)
            {
                button1.Visible = true;
                btn_Add.Text = "Оновити";
            }
            else
            {
                button1.Visible = false;
                btn_Add.Text = "Додати";
            }
        }
    }
}
