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

namespace course_DB
{
    public partial class Регістрація : Form
    {
        string sql = "";
        Frm_Main Frm_Main;
        public Регістрація(Frm_Main frm_Main)
        {
            InitializeComponent();
            Frm_Main = frm_Main;
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            bool check = true;
            SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);

            for(int i = 0; i < Databank.accounts.Count; i++)
            {
                if(tBox_Id.Text == Databank.accounts[i].Id.ToString())
                {
                    MessageBox.Show("Це ID вже використовується!");
                    check = false; break;
                }
            }

            if (check)
            {
                if ((tBox_Id.Text == "") || (tBox_Name.Text == "") || (tBox_Password.Text == "") || (tBox_Position.Text == "") || (tBox_Surname.Text == "") || (tBox_AdminPassword.Text == ""))
                {
                    check = false;
                    MessageBox.Show("Не коректно заповненні поля!");
                }
            }

            if (check)
            {
                for (int i = 0; i < Databank.accounts.Count; i++)
                {
                    if ((Databank.accounts[i].Password == tBox_AdminPassword.Text) && (Databank.accounts[i].Position == "Адміністратор"))
                    {
                        check = true; break;
                    }
                    else
                    {
                        check = false;
                    }
                }
                if (!check)
                {
                    MessageBox.Show("Невірний пароль адміністратора!");
                }
            }
            
            if (check)
            {
                sql = "insert into Accounts (ID, Name, Surname, Password, Position) VALUES (" + tBox_Id.Text + ", '" + tBox_Name.Text + "', '" + tBox_Surname.Text + "', '" + tBox_Password.Text + "', '" + tBox_Position.Text + "')";
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Реєстрація пройшла успішно!");
                this.Hide();
                Databank.SelectAccounts();
                Frm_LogIn frm_LogIn = new Frm_LogIn(Frm_Main);
                frm_LogIn.Show();
            }
        }

        private void Регістрація_Load(object sender, EventArgs e)
        {
            int rec = Databank.accounts[Databank.accounts.Count - 1].Id;
            rec++;
            bool check = recCheck(rec);
            if (check)
            {
                lb_rec.Text += rec.ToString();
            }
            else
            {
                MessageBox.Show("Error_1");
            }
        }

        public bool recCheck(int rec)
        {
            bool check = true;
            for (int i = 0; i < Databank.accounts.Count; i++)
            {
                if (rec == Databank.accounts[i].Id)
                {
                    check = false;
                }
            }
            if (!check)
            {
                recCheck(rec++);
            }
            return check;
        }
    }
}
