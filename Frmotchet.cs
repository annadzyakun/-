using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая_работа_Дзякун
{
    public partial class Frmotchet : Form
    {
        public Frmotchet()
        {
            InitializeComponent();
            DisplayFrmotchet();
        }
        private void btnzakaz_Click_1(object sender, EventArgs e)
        {
            FormMainMenu fmn = new FormMainMenu();
            fmn.Show();
            this.Hide();
        }

        private void btngraf_Click_1(object sender, EventArgs e)
        {
            Frmgraf frmgraf = new Frmgraf();
            frmgraf.Show();
            this.Hide();
        }

        private void btnsotr_Click_1(object sender, EventArgs e)
        {
            Frmsotr frmsotr=new Frmsotr();
            frmsotr.Show();
            this.Hide();
        }

        private void btnyslyga_Click_1(object sender, EventArgs e)
        {
            Frmyslyga frmyslyga = new Frmyslyga();
            frmyslyga.Show();
            this.Hide();
        }


       

        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""курсовая работа"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFrmotchet()
        {
            Con.Open();
            string Query = "Select * from Отчет";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            // Создаем новый DataTable и заполняем его данными из DataSet
            DataTable dataTable = ds.Tables[0];

            // Вычисляем сумму значений в колонке "Цена"
            decimal sum = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                decimal price;
                if (decimal.TryParse(row["Цена"].ToString(), out price))
                {
                    sum += price;
                }
                else
                {
                    Console.WriteLine("Ошибка при парсинге цены: " + row["Цена"].ToString());
                }
            }

            // Добавляем новую строку "Итого" в DataTable
            DataRow totalRow = dataTable.NewRow();
            totalRow["Название"] = "Итого";
            totalRow["Цена"] = sum; // Присваиваем сумму без форматирования как денежное значение
            dataTable.Rows.Add(totalRow);

            // Обновляем DataSet данными из DataTable
            ds.Tables[0].Merge(dataTable);

            // Присваиваем DataSet к DataSource DataGridView
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void UpdateFilteredDataView(string filter)
        {
            DataTable originalDataTable = (dataGridView1.DataSource as DataTable);

            // Создаем новый DataTable с примененным фильтром
            DataView filteredView = originalDataTable.DefaultView;
            filteredView.RowFilter = filter;
            DataTable filteredDataTable = filteredView.ToTable();

            // Добавляем строку "Итого" в новый DataTable
            DataRow totalRow = filteredDataTable.NewRow();
            totalRow["Название"] = "Итого";

            // Пересчитываем сумму значений в колонке "Цена" для отфильтрованных данных
            decimal sum = 0;
            foreach (DataRow row in filteredDataTable.Rows)
            {
                decimal price;
                if (decimal.TryParse(row["Цена"].ToString(), out price))
                {
                    sum += price;
                }
            }

            totalRow["Цена"] = sum;
            filteredDataTable.Rows.Add(totalRow);

            // Обновляем DataGridView с новым DataTable
            dataGridView1.DataSource = filteredDataTable;
        }


























        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateFilteredDataView($"Фамилия LIKE '%{textBox1.Text}%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateFilteredDataView($"CONVERT(Дата_реализации, 'System.String') LIKE '%{textBox2.Text}%'");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataView filteredView = (dataGridView1.DataSource as DataTable).DefaultView;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    filteredView.RowFilter = $"Цена <=2000";
                    break;
                case 1:
                    filteredView.RowFilter = $"Цена >=2000 AND Цена <=10000";
                    break;
                case 2:
                    filteredView.RowFilter = $"Цена >=10000";
                    break;
                case 3:
                    filteredView.RowFilter = "";
                    break;
            }

            DataTable filteredDataTable = filteredView.ToTable();

            // Добавляем строку "Итого" в новый DataTable 
            DataRow totalRow = filteredDataTable.NewRow();
            totalRow["Название"] = "Итого";

            // Пересчитываем сумму значений в колонке "Цена" для отфильтрованных данных 
            decimal sum = 0;
            foreach (DataRow row in filteredDataTable.Rows)
            {
                decimal price;
                if (decimal.TryParse(row["Цена"].ToString(), out price))
                {
                    sum += price;
                }
            }

            totalRow["Цена"] = sum;
            filteredDataTable.Rows.Add(totalRow);

            // Обновляем DataGridView с новым DataTable        
            dataGridView1.DataSource = filteredDataTable;
        }


        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            var dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("Отчет по работе компании ООО АБСОЛЮТ", dataGridView1);
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

        
  
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnotchet_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
