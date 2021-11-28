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
    public partial class C_CAccount : Form
    {
        public C_CAccount()
        {
            InitializeComponent();
        }

        private void C_CAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_CCA_Cancel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void textBox_CCA_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void button_CCA_Create_Click(object sender, EventArgs e)
        {
            if (textBox_CCA_Name.Text == "" || textBox_CCA_Name.Text =="Admin")
            {
                MessageBox.Show("Write your Name!");
            }
            else if (textBox_CCA_Username.Text == "")
            {
                MessageBox.Show("Write your Email!");
            }
            else if (textBox_CCA_Address.Text == "")
            {
                MessageBox.Show("Write your Email!");
            }
            else if (textBox_CCA_Email.Text == "")
            {
                MessageBox.Show("Write your Address!");
            }
            else if (textBox_CCA_Password.Text == "" || textBox_CCA_ConfirmPassword.Text == "")
            {
                MessageBox.Show("Make a Password!");
            }
            else
            {
                if (textBox_CCA_Password.Text != textBox_CCA_ConfirmPassword.Text)
                {
                    MessageBox.Show("Confirm Password Does not Match!");
                }
                else
                {
                    //Database Logics
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
                    connection.Open();
                    string sql = "INSERT INTO C_List(Name, Username, DateOfBirth, Address, Email, Password, Balance, DueBalance) VALUES('" + textBox_CCA_Name.Text + "','" + textBox_CCA_Username.Text + "','" + dateTimePickerCCA_DoB.Text + "','" + textBox_CCA_Address.Text + "','" + textBox_CCA_Email.Text + "','"+textBox_CCA_Password.Text+"', '"+0+"', '"+0+"')";
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

                    connection.Close();

                }

            }
        }

        private void checkBox_CCA_Confirmation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CCA_Confirmation.Checked)
            {
                button_CCA_Create.Enabled = true;
            }
            else
            {
                button_CCA_Create.Enabled = false;
            }
        }
    }
}
