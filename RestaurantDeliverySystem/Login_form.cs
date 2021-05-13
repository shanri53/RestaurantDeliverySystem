using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace RestaurantDeliverySystem
{


    public partial class Login_form : Form
    {
        //private readonly restaurant_delivery_systemEntities restaurantEntities;
        public Login_form()
        {
            InitializeComponent();
            //restaurantEntities = new restaurant_delivery_systemEntities();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register_form login = new Register_form();
            login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //restaurantEntities.user_tbl.//
            /*
            var username = tb_username.Text;
            var password = tb_password.Text;
            SqlConnection con = new SqlConnection("Data Source=desktop-78dveua\sqlexpress;Initial Catalog=restaurant_delivery_system;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from user_tbl where email='" + username + "' and password='" + password + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            //sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i<dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["email"].ToString() == tb_username.Text)
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("table error");
            }
            //if (username.Text == )
            {

            }
            */
            try
            {


                string conString = @"Data Source=desktop-78dveua\sqlexpress;Initial Catalog=restaurant_delivery_system;Integrated Security=True";
                string select = "select * from restaurant_delivery_system.dbo.user_tbl where email='" + this.tb_username.Text + "' and password='" + this.tb_password + "';";
                SqlConnection conDataBase = new SqlConnection(conString);
                SqlCommand cmdDataBase = new SqlCommand("select email,password from restaurant_delivery_system.dbo.user_tbl where email='" + this.tb_username.Text + "' and password='" + this.tb_password + "';", conDataBase);
                SqlDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count =1;
                }
                
                if (count == 1)
                {
                    MessageBox.Show("username and password is correct");
                    /*
                    this.Hide();
                    Restaurant_form login = new Restaurant_form();
                    login.ShowDialog();
                    this.Close();
                    */
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate username and password");
                }
                else
                {
                    MessageBox.Show("wrong credentials... please try again");

                }

                MessageBox.Show(count.ToString());
                this.Hide();
                Restaurant_form login = new Restaurant_form();
                login.ShowDialog();
                this.Close();
                conDataBase.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
