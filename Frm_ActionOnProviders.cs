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
    public partial class Frm_ActionOnProviders : Form
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        bool Update;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        Frm_Providers frm_Providers;
        public Frm_ActionOnProviders(bool updateOrInsert, Frm_Providers Frm_Providers)
        {
            InitializeComponent();
            Update = updateOrInsert;
            frm_Providers = Frm_Providers;
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            string sql = "";
            bool check = true;
            SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);

            for (int i = 0; i < Databank.providers.Count; i++)
            {
                if ((tBox_Id.Text == Databank.providers[i].Id.ToString()) && (Update == false))
                {
                    MessageBox.Show("Це ID вже використовується!");
                    check = false; break;
                }
            }

            if (Update)
            {
                bool good = false;
                for (int i = 0; i < Databank.providers.Count; i++)
                {
                    if (tBox_Id.Text == Databank.providers[i].Id.ToString())
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
                if ((tBox_Id.Text == "") || (tBox_Name.Text == "") || (tBox_Surname.Text == "") || (tBox_Contact.Text == ""))
                {
                    check = false;
                    MessageBox.Show("Некоректно заповненні поля!");
                }
            }

            if ((check) && (!Update))
            {
                sql = "insert into Providers (ID, Name, Surname, Contact) VALUES (" + tBox_Id.Text + ", '" + tBox_Name.Text + "', '" + tBox_Surname.Text + "', '" + tBox_Contact.Text + "')";
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Дія пройшла успішно!");
            }
            else if ((check) && (Update))
            {
                sql = "update Providers set ID = " + tBox_Id.Text + ", Name = '" + tBox_Name.Text + "', Surname = '" + tBox_Surname.Text + "', Contact = '" + tBox_Contact.Text + "' where ID = " + tBox_Id.Text;
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Дія пройшла успішно!");
            }

            frm_Providers.UpdateDate();
            this.Hide();
        }

        private void Frm_ActionOnProviders_Load(object sender, EventArgs e)
        {
            if (Update)
            {
                btn_Action.Name = "Оновити";
                btn_search.Visible = true;
            }
            else
            {
                btn_Action.Name = "Додати";
                btn_search.Visible = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool check = true;
            for (int i = 0; i < Databank.providers.Count; i++)
            {
                if(tBox_Id.Text == Databank.providers[i].Id.ToString())
                {
                    tBox_Name.Text = Databank.providers[i].Name;
                    tBox_Surname.Text = Databank.providers[i].Surname;
                    tBox_Contact.Text = Databank.providers[i].Contact;
                    check = false;
                    break;
                }
            }
            if( check )
            {
                MessageBox.Show("Не вірно вказано ID!");
            }
        }
    }
}
