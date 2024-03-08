using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая_работа_Дзякун
{
    public partial class Frmgraf : Form
    {
        public Frmgraf()
        {
            InitializeComponent();
            DisplayFrmgraf();
        }

        private void Frmgraf_Load(object sender, EventArgs e)
        {

        }

        private void btnzakaz_Click_1(object sender, EventArgs e)
        {
            FormMainMenu fmm = new FormMainMenu();
            fmm.Show();
            this.Hide();
        }

        private void btngraf_Click(object sender, EventArgs e)
        {
            Frmgraf fmm = new Frmgraf();
            fmm.Show();
            this.Hide();
        }

        private void btnsotr_Click_1(object sender, EventArgs e)
        {
           Frmsotr frm=new Frmsotr();
            frm.Show();
            this.Hide();
        }

        private void btnyslyga_Click_1(object sender, EventArgs e)
        {
            Frmyslyga fry = new Frmyslyga();
            fry.Show();
            this.Hide();
        }

        private void btnotchet_Click_1(object sender, EventArgs e)
        {

            Frmotchet fro = new Frmotchet();
            fro.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""курсовая работа"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFrmgraf()
        {
            Con.Open();
            string Query = "Select*from Отчет ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"CONVERT(Дата_реализации, 'System.String') LIKE '%{textBox2.Text}%'";
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            var dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("График работы ООО АБСОЛЮТ", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // получение выбранной строки
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


            // получение значений ячеек выбранной строки
            string номерЗаказа = row.Cells["Номер_заказа"].Value.ToString();
            string датареализации = row.Cells["Дата_реализации"].Value.ToString();
            string услуга = row.Cells["Услуга_id"].Value.ToString();
            string название = row.Cells["Название"].Value.ToString();
            string цена = row.Cells["Цена"].Value.ToString();
            string id_сотрудника = row.Cells["id_сотрудника"].Value.ToString();
            string Фамилия = row.Cells["Фамилия"].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
