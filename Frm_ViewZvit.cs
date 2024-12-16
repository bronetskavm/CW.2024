using course_DB.Classes;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace course_DB
{
    public partial class Frm_ViewZvit : Form
    {
        string dateId;
        double fullPrice = 0;
        double clearIncome = 0;
        string fileName;
        Frm_Zvits frm_Zvits;
        string sql = "";
        DateTime now = DateTime.Now;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Frm_ViewZvit(string dateId, Frm_Zvits frm_Zvits)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            this.dateId = dateId;
            this.frm_Zvits = frm_Zvits;
        }

        private void btn_CreateSave_Click(object sender, EventArgs e)
        {
            fileName = $"{dateId}-{now.Day}.{now.Month}.{now.Year}";
            string filePath = $@"C:\Users\illya\OneDrive\Desktop\курсач\course_DB\Zvits\{fileName}.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(tBox_output.Text);
            }
            MessageBox.Show("Файл успішно створено!");
            addToAllZvit();
            sql = "Delete from Zvits where DateID = '" + dateId + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd.ExecuteNonQuery();
            frm_Zvits.UpdateDate();
            this.Hide();
        }

        private void Frm_ViewZvit_Load(object sender, EventArgs e)
        {
            Databank.SelectDelivers();
            tBox_output.Text += $"Звіт зроблено - {now.Day}.{now.Month}.{now.Year} за датою {dateId}";
            tBox_output.Text += Environment.NewLine;
            tBox_output.Text += $"Оформив звіт - {Databank.accounts[Databank.AccountIdNow - 1].Surname} {Databank.accounts[Databank.AccountIdNow - 1].Name}";
            tBox_output.Text += Environment.NewLine;
            tBox_output.Text += "ID товару | Назва товару | Кількість | Ціна/шт | Загалом ціна | Продавець";
            for (int i = 0; i < Databank.Zvits.Count; i++)
            {
                if (dateId == Databank.Zvits[i].DateId)
                {
                    tBox_output.Text += Environment.NewLine;
                    string rowText = $"{Databank.Zvits[i].ProductId} | {Databank.Zvits[i].ProductName} | {Databank.Zvits[i].Numbers} | {Databank.Zvits[i].Price} | {Databank.Zvits[i].AllPrice} | {Databank.accounts[Databank.Zvits[i].AccountId - 1].Surname}";
                    tBox_output.Text += rowText;
                    fullPrice += Databank.Zvits[i].AllPrice;
                    clearIncome += Databank.Zvits[i].AllPrice - (Databank.Deliverys[searchIdDeliv(Databank.Zvits[i].ProductId) - 1].PricePiece * Databank.Zvits[i].Numbers);
                }
            }
            tBox_output.Text += Environment.NewLine;
            tBox_output.Text += $"Загальна виручка становить - {fullPrice} грн.";
        }

        public void addToAllZvit()
        {
            sql = $"insert into AllZvitsStatics (ZvitID, Income, NetIncome) values ('{fileName}', {fullPrice}, {clearIncome})";
            SQLiteCommand cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd.ExecuteNonQuery();
        }

        public int searchIdDeliv(string Prodid)
        {
            int id = 0;
            for(int i = 0; i < Databank.Deliverys.Count; i++)
            {
                if(Prodid == Databank.Deliverys[i].ProductID)
                {
                    id = Databank.Deliverys[i].Id; break;
                }
            }
            return id;
        }

    }
}
