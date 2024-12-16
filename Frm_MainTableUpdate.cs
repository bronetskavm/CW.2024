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
    public partial class Frm_MainTableUpdate : Form
    {
        Frm_Main Frm_Main;
        public Frm_MainTableUpdate(Frm_Main frm_Main)
        {
            InitializeComponent();
            Frm_Main = frm_Main;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            bool check = true;
            bool good = false;
            int id = 0;
            for (int i = 0; i < Databank.tableMains.Count; i++)
            {
                if (tbox_id.Text == Databank.tableMains[i].Id.ToString())
                {
                    id = i;
                    good = true; break;
                }
            }
            if (!good)
            {
                MessageBox.Show("Не вірно вказано ID!");
            }

            if (check)
            {
                if ((tbox_id.Text == "") || (tbox_number.Text == ""))
                {
                    check = false;
                    MessageBox.Show("Некоректно заповненні поля!");
                }
            }

            if (check)
            {
                Databank.tableMains[id].Number = Convert.ToInt32(tbox_number.Text) - 1;
                MessageBox.Show("Дія пройшла успішно!");
            }

            Databank.tableInput(Frm_Main, id, tbox_id.Text);
            this.Hide();
        }
    }
}
