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
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            DisplayFormMaimMenu();
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitlebar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.SkyBlue;
                    previousBtn.ForeColor = Color.Navy;
                    previousBtn.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void btnzakaz_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }
        private void btnyslyga_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Frmyslyga fct = new Frmyslyga();
            fct.Show();
            this.Hide();
            Frmyslyga Obj = new Frmyslyga();
            Obj.Show();
            this.Hide();
        }

        private void btnsotr_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Frmsotr fct=new Frmsotr();
            fct.Show();
            this.Hide();
        }

        private void btngraf_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Frmgraf fct = new Frmgraf();
            fct.Show();
            this.Hide();
        }

        private void btnotchet_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Frmotchet fct = new Frmotchet();
            fct.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""курсовая работа"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFormMaimMenu()
        {
            Con.Open();
            string Query = "Select*from Заказчик ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            nomTb.Text = "";
            ФИОTb.Text = "";
            АдресTB.Text = "";
            Дата_реализацииTb.Text = "";
            Номер_телефонаTb.Text = "";
            УслугаCb.SelectedIndex =-1;
            ПлощадьTb.Text = "";
            Комментарийtb.Text = "";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nomTb.Text == "" || ФИОTb.Text == "" || АдресTB.Text == "" || Номер_телефонаTb.Text == "" || УслугаCb.SelectedIndex == -1 || ПлощадьTb.Text == "" || Комментарийtb.Text == "")
            {
                MessageBox.Show("введите данные");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Заказчик (Номер_заказа, ФИО, Адрес,Дата_реализации,Номер_телефона,Услуга, Площадь,Комментарий) values(@EN, @EF,@EA,@ED, @ENt,@EY,@EP,@EK) ", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.Parameters.AddWithValue("@EF", ФИОTb.Text);
                    cmd.Parameters.AddWithValue("@EA", АдресTB.Text);
                    cmd.Parameters.AddWithValue("@ED", Дата_реализацииTb.Value.Date);
                    cmd.Parameters.AddWithValue("@ENt", Номер_телефонаTb.Text);
                    cmd.Parameters.AddWithValue("@EY", УслугаCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EP", ПлощадьTb.Text);
                    cmd.Parameters.AddWithValue("@EK", Комментарийtb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заказчик добавлен");
                    Con.Close();
                    DisplayFormMaimMenu();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // получение выбранной строки
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                string номерЗаказа = row.Cells["Номер_заказа"].Value.ToString();
                string фио = row.Cells["ФИО"].Value.ToString();
                string адрес = row.Cells["Адрес"].Value.ToString();
                string датаРеализации = row.Cells["Дата_реализации"].Value.ToString();
                string номерТелефона = row.Cells["Номер_телефона"].Value.ToString();
                string услуга = row.Cells["Услуга"].Value.ToString();
                string площадь = row.Cells["Площадь"].Value.ToString();
                string комментарий = row.Cells["Комментарий"].Value.ToString();

                nomTb.Text = номерЗаказа;
                ФИОTb.Text = фио;
                АдресTB.Text = адрес;
                Дата_реализацииTb.Text = датаРеализации;
                Номер_телефонаTb.Text = номерТелефона;
                УслугаCb.SelectedItem = услуга;
                ПлощадьTb.Text = площадь;
                Комментарийtb.Text = комментарий;
            }
            else
            {
                MessageBox.Show("Выберите заказчика для обновления");
            }
        }
            private void deletebtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("delete from Заказчик where Номер_заказа=@EN", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заказчик удален");
                    Con.Close();
                    Clear();
                    DisplayFormMaimMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // получение выбранной строки
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


            // получение значений ячеек выбранной строки
            string номерЗаказа = row.Cells["Номер_заказа"].Value.ToString();
            string фио = row.Cells["ФИО"].Value.ToString();
            string адрес = row.Cells["Адрес"].Value.ToString();
            string датаРеализации = row.Cells["Дата_реализации"].Value.ToString();
            string номерТелефона = row.Cells["Номер_телефона"].Value.ToString();
            string услуга = row.Cells["Услуга"].Value.ToString();
            string площадь = row.Cells["Площадь"].Value.ToString();
            string комментарий = row.Cells["Комментарий"].Value.ToString();

            nomTb.Text = номерЗаказа;
            ФИОTb.Text = фио;
            АдресTB.Text = адрес;
            Дата_реализацииTb.Text = датаРеализации;
            Номер_телефонаTb.Text = номерТелефона;
            УслугаCb.SelectedItem = услуга;
            ПлощадьTb.Text = площадь;
            Комментарийtb.Text = комментарий;
        }



















        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ФИОTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
