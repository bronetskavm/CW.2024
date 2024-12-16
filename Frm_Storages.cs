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
    public partial class Frm_Storages : Form
    {
        public Frm_Storages()
        {
            InitializeComponent();
        }

        private void Frm_Storages_Load(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Frm_StorageUpdate frm = new Frm_StorageUpdate(this);
            frm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Frm_StorageDelete frm = new Frm_StorageDelete(this);
            frm.Show();
        }

        public void UpdateDate()
        {
            DataTable table = new DataTable();
            Databank.SelectStorage();

            table.Columns.Add("ID товару", typeof(string));
            table.Columns.Add("Назва товару", typeof(string));
            table.Columns.Add("Кількість на складі", typeof(int));
            table.Columns.Add("Ціна/шт", typeof(double));
            table.Columns.Add("Загальна ціна", typeof(double));
            table.Columns.Add("Срок придатності", typeof(string));
            table.Columns.Add("ID постачальника", typeof(int));
            table.Columns.Add("ID поставки", typeof(int));

            for (int i = 0; i < Databank.storages.Count; i++)
            {
                table.Rows.Add(Databank.storages[i].Id, Databank.storages[i].Name, Databank.storages[i].Number, Databank.storages[i].Price, Databank.storages[i].AllPrice, Databank.storages[i].ExpirationDate, Databank.storages[i].ProviderId, Databank.storages[i].DeliveryId);
            }
            dataGrid.DataSource = table;
        }
    }
}
