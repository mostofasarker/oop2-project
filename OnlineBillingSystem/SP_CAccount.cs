using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBillingSystem
{
    public partial class SP_CAccount : Form
    {
        public SP_CAccount()
        {
            InitializeComponent();
        }

        private void SP_CAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_SPCA_Cancel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void button_SPCA_Create_Click(object sender, EventArgs e)
        {
            if (textBox_SPCA_ServiceProviderName.Text == "")
            {
                MessageBox.Show("Write your Name!");
            }
            else if (textBox_SPCA_Email.Text == "")
            {
                MessageBox.Show("Write your Email!");
            }
            else if (textBox_SPCA_Email.Text == "")
            {
                MessageBox.Show("Write your Email!");
            }
            else if (textBox_SPCA_Address.Text == "")
            {
                MessageBox.Show("Write your Address!");
            }
            else if (textBox_SPCA_PhoneNo.Text == "")
            {
                MessageBox.Show("Write your Phone Number!");
            }
            else if (textBox_SPCA_Password.Text == "" || textBox_SPCA_ConfirmPassword.Text == "")
            {
                MessageBox.Show("Make a Password!");
            }
            else
            {
                if (textBox_SPCA_Password.Text != textBox_SPCA_ConfirmPassword.Text)
                {
                    MessageBox.Show("Confirm Password Does not Match!");
                }
                else
                {
                    //Database Logics
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
                    connection.Open();
                    string sql = "INSERT INTO SP_List(SPName, Email, Address, PhoneNumber, Password) VALUES('" + textBox_SPCA_Tittle.Text + textBox_SPCA_ServiceProviderName.Text+ "','" + textBox_SPCA_Email.Text + "','" + textBox_SPCA_Address.Text + "','" + textBox_SPCA_PhoneNo.Text + "','" + textBox_SPCA_Password.Text + "')";
                    SqlCommand command = new SqlCommand(sql, connection);
                    int check = command.ExecuteNonQuery();
                    if (check > 0)
                    {
                        MessageBox.Show("Sign up Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Error!\nTry Again.");

                    }

                    Home home = new Home();
                    this.Hide();
                    home.Show();

                    //string sql1 = "Create table '" + textBox_SPCA_ServiceProviderName + "'(C_ID int, C_Name varchar(50), C_Balance int, C_DueBalance int )";
                    //SqlCommand command_1 = new SqlCommand(sql1, connection);
                    //int check_1 = command_1.ExecuteNonQuery();
                    //if (check_1 > 0)
                    //{
                    //    MessageBox.Show("Table Created!");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error!\nTry Again.");

                    //}

                    connection.Close();

                }

            }
        }

        private void checkBox_SPCA_Confirmation_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_SPCA_Confirmation.Checked)
            {
                button_SPCA_Create.Enabled = true;
            }
            else
            {
                button_SPCA_Create.Enabled = false;
            }
        }

        private void label_SPCA_ServiceProviderName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_SPCA_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
