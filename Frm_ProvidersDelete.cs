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
    public partial class Frm_ProvidersDelete : Form
    {
        string sql = "";
        Frm_Providers frm_Providers;
        public Frm_ProvidersDelete(Frm_Providers frm_Providers)
        {
            InitializeComponent();
            this.frm_Providers = frm_Providers;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = "";
            if (tbox_ID.Text == "")
            {
                MessageBox.Show("Поле пусте!");
            }

            for (int i = 0; i < Databank.providers.Count; i++)
            {
                if (tbox_ID.Text == Databank.providers[i].Id.ToString())
                {
                    id = Databank.providers[i].Id.ToString();
                }
            }

            if (id != "")
            {
                SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);
                sql = "DELETE from Providers WHERE ID = " + id;
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
                frm_Providers.UpdateDate();
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
