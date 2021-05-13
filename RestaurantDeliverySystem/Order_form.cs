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
    public partial class Order_form : Form
    {
        public Order_form()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            KFC_form select = new KFC_form();
            select.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            OrderList_form select = new OrderList_form();
            select.ShowDialog();
            this.Close();
        }

        private void ordertblBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usertblBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
