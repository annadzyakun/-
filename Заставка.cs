using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая_работа_Дзякун
{
    public partial class Заставка : Form
    {
        public Заставка()
        {
            InitializeComponent();
            timer1.Start();
        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            Myprogress.Value = startP;
            prozlbl.Text = startP + "%";
            if(Myprogress.Value ==100)
            {
                Myprogress.Value = 0;
                FormMainMenu Obj= new FormMainMenu();
                Obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }
    }
}
