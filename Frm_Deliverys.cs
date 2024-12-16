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
    public partial class Frm_Deliverys : Form
    {
        Frm_Main frm_Main = new Frm_Main();
        public Frm_Deliverys()
        {
            InitializeComponent();
        }

        private void Frm_Deliverys_Load(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void btn_Scaner_Click(object sender, EventArgs e)
        {
            Frm_Scaner frm_scaner = new Frm_Scaner(frm_Main, this, false);
            frm_scaner.Show();
        }

        private void btn_AddDeliv_Click(object sender, EventArgs e)
        {
            Frm_DelivAddItems frm = new Frm_DelivAddItems(this, false);
            frm.Show();
        }

        private void btn_UpdateDeliv_Click(object sender, EventArgs e)
        {
            Frm_DelivAddItems frm = new Frm_DelivAddItems(this, true);
            frm.Show();
        }

        private void btn_DeleteDeliv_Click(object sender, EventArgs e)
        {
            Frm_DelivDelete frm = new Frm_DelivDelete(this);
            frm.Show();
        }

        public void UpdateDate()
        {
            Databank.SelectDelivers();
            DataTable table = new DataTable();

            table.Columns.Add("ID поставки", typeof(int));
            table.Columns.Add("ID товару", typeof(string));
            table.Columns.Add("Назва", typeof(string));
            table.Columns.Add("Кількість", typeof(int));
            table.Columns.Add("Ціна/шт", typeof(double));
            table.Columns.Add("Загальна ціна", typeof(double));
            table.Columns.Add("Дата прибуття", typeof(string));
            table.Columns.Add("ID постачальника", typeof(int));

            for (int i = 0; i < Databank.Deliverys.Count; i++)
            {
                table.Rows.Add(Databank.Deliverys[i].Id, Databank.Deliverys[i].ProductID, Databank.Deliverys[i].NameProduct, Databank.Deliverys[i].Numbers, Databank.Deliverys[i].PricePiece, Databank.Deliverys[i].AllPrice, Databank.Deliverys[i].Arrival, Databank.Deliverys[i].ProviderId);
            }
            dataGridView.DataSource = table;
        }
    }
}
