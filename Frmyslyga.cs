using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace курсовая_работа_Дзякун
{
    public partial class Frmyslyga : Form
    {
        public Frmyslyga()
        {
            InitializeComponent();
            DisplayFrmyslyga();
        }
        SqlConnection Con = new SqlConnection("Data Source=ANNA;Initial Catalog=\"курсовая работа\";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFrmyslyga()
        { Con.Open();
            string query = "Select*From Услуга ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds=new DataSet();
            SDA.Fill(ds);
            DgView.DataSource = ds.Tables[0];
            Con.Close();
        }
      
        private void Clear()
        {
            nomTb.Text = "";
            txtname.Text = "";
            txtmat.Text = "";
            txthim.Text = "";
            txtobor.Text = "";
            txtcen.Text = "";
        }
        private void addbtn_Click_1(object sender, EventArgs e)
        {
            if (nomTb.Text == "" || txtname.Text == "" || txtmat.Text == "" ||txthim.Text == "" || txtobor.Text == "" || txtcen.Text == "")
            {
                MessageBox.Show("введите данные");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Услуга (Услуга_id,Название, Материалы,Химия, Оборудование,Цена) values(@EN, @EF,@EA, @ENt,@EP,@EK) ", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.Parameters.AddWithValue("@EF", txtname.Text);
                    cmd.Parameters.AddWithValue("@EA", txtmat.Text);                  
                    cmd.Parameters.AddWithValue("@ENt", txthim.Text);                   
                    cmd.Parameters.AddWithValue("@EP", txtobor.Text);
                    cmd.Parameters.AddWithValue("@EK", txtcen.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Услуга добавлена");
                    Con.Close();
                    DisplayFrmyslyga();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void updatebtn_Click_1(object sender, EventArgs e)
        {

            if (DgView.SelectedRows.Count > 0)
            {
                // получение выбранной строки
                DataGridViewRow row = DgView.SelectedRows[0];

                string номер = row.Cells["Услуга_id"].Value.ToString();
                string название = row.Cells["Название"].Value.ToString();
                string материалы = row.Cells["Материалы"].Value.ToString();
                string химия = row.Cells["Химия"].Value.ToString();
                string оборудование = row.Cells["Оборудование"].Value.ToString();
                string цена = row.Cells["Цена"].Value.ToString();
              

                nomTb.Text = номер;
                txtname.Text = название;
                txtmat.Text = материалы;
                txthim.Text = химия;
                txtobor.Text = оборудование;
                txtcen.Text = цена;
            }
            else
            {
                MessageBox.Show("Выберите заказчика для обновления");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(nomTb.Text))
                {
                    MessageBox.Show("Введите номер заказа");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("delete from Услуга where Услуга_id=@EN", Con);
                        cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Заказчик удален");
                        Con.Close();
                        Clear();
                        DisplayFrmyslyga();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

       
        private void btnzakaz_Click_1(object sender, EventArgs e)
        {
            FormMainMenu fm = new FormMainMenu();
            fm.Show();
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
          Frmsotr fs = new Frmsotr();
            fs.Show();
            this.Hide();
        }

        private void btnyslyga_Click_1(object sender, EventArgs e)
        {
            Frmyslyga fs = new Frmyslyga();
            fs.Show();
            this.Hide();
        }

        private void btnotchet_Click_1(object sender, EventArgs e)
        {
            Frmotchet frmotchet
                = new Frmotchet();
            frmotchet.Show();
            this.Hide();
        }
        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nomTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmyslyga_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
    