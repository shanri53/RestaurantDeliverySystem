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

namespace RestaurantDeliverySystem
{
    public partial class Register_form : Form
    {
        private readonly restaurant_delivery_systemEntities1 restaurantEntities;
        public Register_form()
        {
            InitializeComponent();
            restaurantEntities = new restaurant_delivery_systemEntities1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var fname = tb_fname.Text.ToString();
                var lname = tb_lname.Text.ToString();
                var email = tb_email.Text.ToString();
                var password = tb_pass.Text.ToString();
                var conPassword = tb_conPass.Text.ToString();
                var address = tb_address.Text.ToString();
                bool valid = true;
                var errorMessage = "";

                
                
                if (string.IsNullOrWhiteSpace(fname)
                    || string.IsNullOrWhiteSpace(lname)
                    || string.IsNullOrWhiteSpace(email)
                    || string.IsNullOrWhiteSpace(address)
                    || string.IsNullOrWhiteSpace(password)
                    || string.IsNullOrWhiteSpace(conPassword)
                    )
                {
                    errorMessage += "Please enter missing data\n\r";
                    valid = false;
                }
                else
                {
                    valid = true;
                }

                if (password != conPassword)
                {
                    errorMessage += "Password does not match Confirm Password\n\r";
                    valid = false;
                }
                if (valid)
                {
                    string conString = @"Data Source=desktop-78dveua\sqlexpress;Initial Catalog=restaurant_delivery_system;Integrated Security=True";
                    string query = "insert into restaurant_delivery_system.dbo.user_tbl (fname,lname,email,password,address) values('" + fname + "','" + lname + "','" + email + "','" + password + "' , '" + address + "');";
                    SqlConnection conDataBase = new SqlConnection(conString);
                    SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
                    SqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Saved");
                        while (myReader.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //restaurantEntities.user_tbl.Add(adduser);   
                    //restaurantEntities.SaveChanges();

                    MessageBox.Show("Thank you for registering");
                    this.Hide();
                    Login_form login = new Login_form();
                    login.ShowDialog();
                    this.Close();
                }
                
                else
                {
                    MessageBox.Show(errorMessage);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form login = new Login_form();
            login.ShowDialog();
            this.Close();
        }
    }
}
