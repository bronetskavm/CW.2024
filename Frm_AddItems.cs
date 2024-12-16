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
    public partial class Frm_AddItems : Form
    {
        Frm_Main frm_Main;
        public Frm_AddItems(Frm_Main frm_Main)
        {
            InitializeComponent();
            this.frm_Main = frm_Main;
        }

        private void btn_addItems_Click(object sender, EventArgs e)
        {
            bool check = true;
            int id_storage;
            for (int i = 0; i < Databank.storages.Count; i++)
            {
                if (tBox_inputId.Text == Databank.storages[i].Id.ToString())
                {
                    if(numUpDowm.Value <= Databank.storages[i].Number)
                    {
                        id_storage = i;
                        for (int j = 0; j < numUpDowm.Value; j++)
                        {
                            Databank.tableInput(frm_Main, id_storage, tBox_inputId.Text);
                            check = false;
                        }
                    }
                    else
                    {
                        check = false;
                        MessageBox.Show("На складі нема такої кількості!");
                        break;
                    }
                }
            }
            if (check)
            {
                MessageBox.Show("Не вірно вказано ID");
            }
        }

        private void Frm_AddItems_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            Databank.SelectStorage();

            table.Columns.Add("ID товару", typeof(string));
            table.Columns.Add("Назва товару", typeof(string));
            table.Columns.Add("Кількість на складі", typeof(int));
            table.Columns.Add("Ціна/шт", typeof(double));
            table.Columns.Add("Срок придатності", typeof(string));

            for (int i = 0; i < Databank.storages.Count; i++)
            {
                table.Rows.Add(Databank.storages[i].Id, Databank.storages[i].Name, Databank.storages[i].Number, Databank.storages[i].Price, Databank.storages[i].ExpirationDate);
            }
            dataGridOutputStorage.DataSource = table;
        }
    }
}
