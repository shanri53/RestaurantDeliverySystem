using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDeliverySystem
{
    public partial class Restaurant_form : Form
    {
        public Restaurant_form()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form login = new Login_form();
            login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            KFC_form KFC = new KFC_form();
            KFC.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BK_form bk = new BK_form();
            bk.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pizzaHut_form PH = new pizzaHut_form();
            PH.ShowDialog();
            this.Close();
        }
    }
}
