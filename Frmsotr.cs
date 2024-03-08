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
        }
        private void btnzakaz_Click(object sender, EventArgs e)
        {
            FormMainMenu fm = new FormMainMenu();
            fm.Show();
            this.Hide();
        }

        private void btnyslyga_Click(object sender, EventArgs e)
        {
            Frmyslyga fy = new Frmyslyga();
            fy.Show();
            this.Hide();
        }

        private void btnsotr_Click_1(object sender, EventArgs e)
        {
            Frmsotr fs = new Frmsotr();
            fs.Show();
            this.Hide();
        }

        private void btngraf_Click_1(object sender, EventArgs e)
        {
            Frmgraf frm = new Frmgraf();
            frm.Show();
            this.Hide();
        }

        private void btnotchet_Click_1(object sender, EventArgs e)
        {
            Frmotchet frmotchet = new Frmotchet();
            frmotchet.Show();
            this.Hide();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""курсовая работа"";Integrated Security=True;Connect Timeout=30;"); SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String sFileName = openFileDialog1.FileName; pictureBox1.Image = Image.FromFile(sFileName);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Сотрудник ON; INSERT INTO Сотрудник (id_сотрудника, Фамилия, Имя, Отчество, Фото) VALUES (@id_сотрудника, @Фамилия, @Имя, @Отчество, @Фото); SET IDENTITY_INSERT Сотрудник OFF;", Con);

            cmd.Parameters.AddWithValue("@id_сотрудника", nomTb.Text);
            cmd.Parameters.AddWithValue("@Фамилия", faTb.Text);
            cmd.Parameters.AddWithValue("@Имя", IMTB.Text);
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
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[4];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсовая_работаDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.курсовая_работаDataSet.Сотрудник);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomTb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            faTb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); IMTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            OtchTb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[4].Value);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("UPDATE Сотрудник Set Фамилия=@Фамилия, Имя=@Имя, Отчество=@Отчество, Фото=@Фото Where id_сотрудника=@id_сотрудника", Con);
            cmd.Parameters.AddWithValue("@Фамилия", faTb.Text);
            cmd.Parameters.AddWithValue("@Имя", IMTB.Text);
            cmd.Parameters.AddWithValue("@Отчество", OtchTb.Text);
            MemoryStream memorysteam = new MemoryStream();
            pictureBox1.Image.Save(memorysteam, pictureBox1.Image.RawFormat);
            cmd.Parameters.AddWithValue("Фото", memorysteam.ToArray()); cmd.Parameters.AddWithValue("id_сотрудника", nomTb.Text);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            load_data();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE  Сотрудник Where id_Сотрудника=@id_Сотрудника", Con);
            cmd.Parameters.AddWithValue("id_Сотрудника", nomTb.Text);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            load_data();
            pictureBox1.Image = null;
            faTb.Text = "";
            IMTB.Text = "";
            OtchTb.Text = "";
            nomTb.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
