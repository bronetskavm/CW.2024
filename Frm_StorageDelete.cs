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
    public partial class Frm_StorageDelete : Form
    {
        string sql = "";
        Frm_Storages frm_Storages;
        public Frm_StorageDelete(Frm_Storages frm_Storages)
        {
            InitializeComponent();
            this.frm_Storages = frm_Storages;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = "";
            if (tBox_Id.Text == "")
            {
                MessageBox.Show("Поле пусте!");
            }

            for (int i = 0; i < Databank.storages.Count; i++)
            {
                if (tBox_Id.Text == Databank.storages[i].Id.ToString())
                {
                    id = Databank.storages[i].Id.ToString();
                }
            }

            if (id != "")
            {
                SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);
                sql = "DELETE from Storage WHERE ID = " + id;
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
                frm_Storages.UpdateDate();
                MessageBox.Show("Дія успішно виконана!");
                this.Hide();
            }
            else if ((tBox_Id.Text != "") && (id == ""))
            {
                MessageBox.Show("Не вірно вказано ID!");
            }
        }
    }
}
