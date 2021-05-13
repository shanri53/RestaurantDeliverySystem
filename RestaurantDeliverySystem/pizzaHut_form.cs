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
    public partial class pizzaHut_form : Form
    {
        public pizzaHut_form()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant_form select = new Restaurant_form();
            select.ShowDialog();
            this.Close();
        }
        class Total
        {
            public static double total = 0.00;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, p1, p2, p3;

            n1 = Convert.ToDouble(num1.Value);
            n2 = Convert.ToDouble(num2.Value);
            n3 = Convert.ToDouble(num3.Value);
            p1 = Convert.ToDouble(lbl_price1.Text);
            p2 = Convert.ToDouble(lbl_price2.Text);
            p3 = Convert.ToDouble(lbl_price3.Text);


            Total.total = ((n1 * p1) + (n2 * p2) + (n3 * p3));
            lbl_total.Text = "$" + Total.total.ToString();
        }

        private void num2_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, p1, p2, p3;

            n1 = Convert.ToDouble(num1.Value);
            n2 = Convert.ToDouble(num2.Value);
            n3 = Convert.ToDouble(num3.Value);
            p1 = Convert.ToDouble(lbl_price1.Text);
            p2 = Convert.ToDouble(lbl_price2.Text);
            p3 = Convert.ToDouble(lbl_price3.Text);


            Total.total = ((n1 * p1) + (n2 * p2) + (n3 * p3));
            lbl_total.Text = "$" + Total.total.ToString();
        }

        private void num3_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, p1, p2, p3;

            n1 = Convert.ToDouble(num1.Value);
            n2 = Convert.ToDouble(num2.Value);
            n3 = Convert.ToDouble(num3.Value);
            p1 = Convert.ToDouble(lbl_price1.Text);
            p2 = Convert.ToDouble(lbl_price2.Text);
            p3 = Convert.ToDouble(lbl_price3.Text);


            Total.total = ((n1 * p1) + (n2 * p2) + (n3 * p3));
            lbl_total.Text = "$" + Total.total.ToString();
        }
        private void btn_history_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order_form select = new Order_form();
            select.ShowDialog();
            this.Close();
        }
    }
}
