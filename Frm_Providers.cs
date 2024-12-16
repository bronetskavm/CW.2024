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
    public partial class Frm_Providers : Form
    {

        public Frm_Providers()
        {
            InitializeComponent();
        }

        private void Frm_Providers_Load(object sender, EventArgs e)
        {
            UpdateDate();
        }
        private void btn_AddProvider_Click(object sender, EventArgs e)
        {
            Frm_ActionOnProviders frm_ActionOnProviders = new Frm_ActionOnProviders(false, this);
            frm_ActionOnProviders.Show();
            UpdateDate();
        }

        public void UpdateDate()
        {
            Databank.SelectProviders();
            DataTable table = new DataTable();

            table.Columns.Add("ID постачальника", typeof(int));
            table.Columns.Add("Ім'я", typeof(string));
            table.Columns.Add("Прізвище", typeof(string));
            table.Columns.Add("Контакти", typeof(string));

            for (int i = 0; i < Databank.providers.Count; i++)
            {
                table.Rows.Add(Databank.providers[i].Id, Databank.providers[i].Name, Databank.providers[i].Surname, Databank.providers[i].Contact);
            }
            dataGridView.DataSource = table;
        }

        private void btn_UpdateProvider_Click(object sender, EventArgs e)
        {
            Frm_ActionOnProviders frm_ActionOnProviders = new Frm_ActionOnProviders(true, this);
            frm_ActionOnProviders.Show();
        }

        private void btn_DeleteProvider_Click(object sender, EventArgs e)
        {
            Frm_ProvidersDelete frm = new Frm_ProvidersDelete(this);
            frm.Show();
        }
    }
}
