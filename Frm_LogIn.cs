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

namespace course_DB
{
    public partial class Frm_LogIn : Form
    {
        bool check = true;
        Frm_Main frm_Main;
        public Frm_LogIn(Frm_Main frm_Main)
        {
            InitializeComponent();
            this.frm_Main = frm_Main;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Databank.accounts.Count; i++)
            {
                if ((tBox_Surname.Text == Databank.accounts[i].Surname) && (tBox_Password.Text == Databank.accounts[i].Password))
                {
                    frm_Main.lb_Name.Text = Databank.accounts[i].Surname.ToString() + " " + Databank.accounts[i].Name.ToString();
                    frm_Main.lb_Position.Text = Databank.accounts[i].Position.ToString();
                    Databank.AccPosition = Databank.accounts[i].Position.ToString();
                    Databank.AccountIdNow = Databank.accounts[i].Id;
                    check = false;
                    this.Hide();
                }
            }

            if (check)
            {
                MessageBox.Show("Не вірно введені Прізвище або Пароль!");
            }
        }

        private void link_newAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Регістрація frm_Registration = new Регістрація(frm_Main);
            frm_Registration.Show();
        }

        private void Frm_LogIn_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
