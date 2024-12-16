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
    public partial class Frm_Zvits : Form
    {
        public Frm_Zvits()
        {
            InitializeComponent();
        }

        private void Frm_Zvits_Load(object sender, EventArgs e)
        {
            UpdateDate();
        }

        public void UpdateDate()
        {
            Databank.SelectZvits();
            DataTable table = new DataTable();

            table.Columns.Add("Дата", typeof(string));
            table.Columns.Add("ID товару", typeof(string));
            table.Columns.Add("Назва", typeof(string));
            table.Columns.Add("Кількість", typeof(int));
            table.Columns.Add("Ціна/шт", typeof(double));
            table.Columns.Add("Загальна ціна", typeof(double));
            table.Columns.Add("ID продавця", typeof(int));

            for (int i = 0; i < Databank.Zvits.Count; i++)
            {
                table.Rows.Add(Databank.Zvits[i].DateId, Databank.Zvits[i].ProductId, Databank.Zvits[i].ProductName, Databank.Zvits[i].Numbers, Databank.Zvits[i].Price, Databank.Zvits[i].AllPrice, Databank.Zvits[i].AccountId);
            }
            dataGridView.DataSource = table;
        }

        private void btn_CreateZvit_Click(object sender, EventArgs e)
        {
            bool check = false;
            for(int i = 0; i < Databank.Zvits.Count; i++)
            {
                if (tBox_input.Text == Databank.Zvits[i].DateId)
                {
                    check = true;
                    break;
                }
            }

            if(check)
            {
                Frm_ViewZvit frm = new Frm_ViewZvit(tBox_input.Text, this);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Не вірно вказано дату!");
            }
        }
    }
}
