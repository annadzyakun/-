using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace курсовая_работа_Дзякун
{
    public partial class Frmsotr : Form
    {
        public Frmsotr()
        {
            InitializeComponent();
            DisplayFormMaimMenu();
        }
        private void btnzakaz_Click_1(object sender, EventArgs e)
        {
            FormMainMenu fm = new FormMainMenu();
            fm.Show();
            this.Hide();
        }

        private void btngraf_Click(object sender, EventArgs e)
        {
            Frmgraf frm = new Frmgraf();
            frm.Show();
            this.Hide();
        }

        private void btnsotr_Click(object sender, EventArgs e)
        {

        }
        private void btnyslyga_Click_1(object sender, EventArgs e)
        {
            Frmyslyga fy = new Frmyslyga();
            fy.Show();
            this.Hide();
        }

        private void btnotchet_Click(object sender, EventArgs e)
        {
            Frmotchet frmotchet = new Frmotchet();
            frmotchet.Show();
            this.Hide();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }









        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""курсовая работа"";Integrated Security=True;Connect Timeout=30;"); SqlCommand cmd;
        private void DisplayFormMaimMenu()
        {
        }
        


        private void addbtn_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Сотрудник ON; INSERT INTO Сотрудник (id_сотрудника, Фамилия, Имя, Отчество, Фото) VALUES (@id_сотрудника, @Фамилия, @Имя, @Отчество, @Фото); SET IDENTITY_INSERT Сотрудник OFF;", Con);

            cmd.Parameters.AddWithValue("@id_сотрудника", nomTb.Text);
            cmd.Parameters.AddWithValue("@Фамилия", faTb.Text);
            cmd.Parameters.AddWithValue("@Имя", IMTb.Text);
            cmd.Parameters.AddWithValue("@Отчество", OtchTb.Text);

            MemoryStream memorystream = new MemoryStream();
            pictureBox1.Image.Save(memorystream, pictureBox1.Image.RawFormat);
            cmd.Parameters.AddWithValue("@Фото", memorystream.ToArray());

            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Данные успешно добавлены");
        }
        private void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Сотрудник ORDER BY id_сотрудника DESC", Con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView.RowTemplate.Height = 75;
            dataGridView.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView.Columns[4];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void Frmsotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсовая_работаDataSet2.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.курсовая_работаDataSet2.Сотрудник);
            load_data();

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            nomTb.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            faTb.Text = dataGridView.CurrentRow.Cells[1].Value.ToString(); IMTb.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            OtchTb.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();    
          MemoryStream ms =new MemoryStream((byte[])dataGridView.CurrentRow.Cells[4].Value);
            pictureBox1.Image=Image.FromStream(ms);

        }
        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE  Сотрудник Where id_Сотрудника=@id_Сотрудника", Con);
            cmd.Parameters.AddWithValue("id_Сотрудника", nomTb.Text);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            load_data();
            pictureBox1.Image = null;
            faTb.Text = "";
            IMTb.Text = ""; 
            OtchTb.Text = "";
            nomTb.Text = "";
        }
        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Сотрудник Set Фамилия=@Фамилия, Имя=@Имя, Отчество=@Отчество, Фото=@Фото Where id_сотрудника=@id_сотрудника", Con);
            cmd.Parameters.AddWithValue("@Фамилия", faTb.Text);
            cmd.Parameters.AddWithValue("@Имя", IMTb.Text);
            cmd.Parameters.AddWithValue("@Отчество", OtchTb.Text);
            MemoryStream memorysteam = new MemoryStream(); 
            pictureBox1.Image.Save(memorysteam, pictureBox1.Image.RawFormat);
            cmd.Parameters.AddWithValue("Фото", memorysteam.ToArray()); cmd.Parameters.AddWithValue("id_сотрудника", nomTb.Text);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            load_data();


        }





























            private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

       
        private void browserBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.jpeg)|*jpg;*png;*jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
       
        private void dataGridView_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String sFileName = openFileDialog1.FileName; pictureBox1.Image = Image.FromFile(sFileName);
            }
        }

        private void nomTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OtchTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

       
       
    }
}






