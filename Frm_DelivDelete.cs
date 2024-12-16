using course_DB.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_DB
{
    public partial class Frm_DelivDelete : Form
    {
        string sql = "";
        Frm_Deliverys frm_deliv;
        public Frm_DelivDelete(Frm_Deliverys frm_deliv)
        {
            InitializeComponent();
            this.frm_deliv = frm_deliv;
        }

        private void Frm_DelivDelete_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = "";
            if (tbox_ID.Text == "")
            {
                MessageBox.Show("Поле пусте!");
            }

            for (int i = 0; i < Databank.Deliverys.Count; i++)
            {
                if (tbox_ID.Text == Databank.Deliverys[i].Id.ToString())
                {
                    id = Databank.Deliverys[i].Id.ToString();
                }
            }

            if (id != "")
            {
                SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);
                sql = "DELETE from Deliverys WHERE ID = " + id;
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
                frm_deliv.UpdateDate();
                MessageBox.Show("Дія успішно виконана!");
                this.Hide();
            }
            else if ((tbox_ID.Text != "") && (id == ""))
            {
                MessageBox.Show("Не вірно вказано ID!");
            }
        }
    }
}
