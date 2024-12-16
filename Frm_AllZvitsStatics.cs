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
    public partial class Frm_AllZvitsStatics : Form
    {
        public Frm_AllZvitsStatics()
        {
            InitializeComponent();
        }

        private void Frm_AllZvitsStatics_Load(object sender, EventArgs e)
        {
            UpdateDate();
        }

        public void UpdateDate()
        {
            double income = 0;
            DataTable table = new DataTable();
            Databank.SelectAllZvits();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Дата звіту", typeof(string));
            table.Columns.Add("Прибуток", typeof(double));
            table.Columns.Add("Чистий дохід", typeof(double));

            for (int i = 0; i < Databank.AllZvitStatics.Count; i++)
            {
                table.Rows.Add(Databank.AllZvitStatics[i].Id, Databank.AllZvitStatics[i].ZvitId, Databank.AllZvitStatics[i].Income, Databank.AllZvitStatics[i].NetIncome);
                income += Databank.AllZvitStatics[i].NetIncome;
            }
            lb_value.Text = income.ToString() + " грн.";
            dataGridView.DataSource = table;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UpdateDate();
        }
    }
}
