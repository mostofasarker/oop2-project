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
    public partial class SPLP : Form
    {
        Login login;
        public SPLP(Login login)
        {
            InitializeComponent();
            this.login = login;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            string sql = "select * from SP_List where SPName= '" + login.textBox_LP_Username.Text + "' and Password = '" + login.textBox_LP_Password.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            {
                textBox_SPLP_ID.Text = reader["id"].ToString();
                textBox_SPLP_Name.Text = reader["SPName"].ToString();
                textBox_SPLP_Email.Text = reader["Email"].ToString();
                textBox_SPLP_Address.Text = reader["Address"].ToString();
                textBox_SPLP_PhoneNo.Text = reader["PhoneNumber"].ToString();
                textBox_SPLP_Password.Text = reader["Password"].ToString();
            }
        } 

        private void SPLP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_SPLP_Update_Click(object sender, EventArgs e)
        {
            textBox_SPLP_Name.Enabled = true;
            textBox_SPLP_Email.Enabled = true;
            textBox_SPLP_Address.Enabled = true;
            textBox_SPLP_PhoneNo.Enabled = true;
            textBox_SPLP_Password.Enabled = true;
            button_SPLP_Update.Visible = false;
            button_SPLP_UpdateOK.Visible = true;
            button_SPLP_UpdateCancel.Visible = true;
            label_SPLP_ConfirmPassword.Visible = true;
            textBox_SPLP_ConfirmPassword.Visible = true;
        }

        private void button_SPLP_UpdateCancel_Click(object sender, EventArgs e)
        {
            textBox_SPLP_Name.Enabled = false;
            textBox_SPLP_Email.Enabled = false;
            textBox_SPLP_Address.Enabled = false;
            textBox_SPLP_PhoneNo.Enabled = false;
            textBox_SPLP_Password.Enabled = false;
            button_SPLP_Update.Visible = true;
            button_SPLP_UpdateOK.Visible = false;
            button_SPLP_UpdateCancel.Visible = false;
            label_SPLP_ConfirmPassword.Visible = false;
            textBox_SPLP_ConfirmPassword.Visible = false;
        }

        private void button_SPLP_UpdateOK_Click(object sender, EventArgs e)
        {
            if (textBox_SPLP_Name.Text == "")
            {
                MessageBox.Show("Write your Name!");
            }
            else if (textBox_SPLP_Email.Text == "")
            {
                MessageBox.Show("Input an Email!");
            }
            else if (textBox_SPLP_Address.Text == "")
            {
                MessageBox.Show("Write your Address!");
            }
            else if (textBox_SPLP_PhoneNo.Text == "")
            {
                MessageBox.Show("Write your Phone Number!");
            }
            else if (textBox_SPLP_Password.Text == "")
            {
                MessageBox.Show("Input a Password!");
            }
            else if (textBox_SPLP_ConfirmPassword.Text != textBox_SPLP_Password.Text)
            {
                MessageBox.Show("Passwords Do not Match!");
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
                connection.Open();
                string sql = "UPDATE SP_List SET SPName = '" + textBox_SPLP_Name.Text + "', Email = '" + textBox_SPLP_Email.Text + "',Address = '" + textBox_SPLP_Address.Text + "' ,PhoneNumber = '" + textBox_SPLP_PhoneNo.Text + "', Password = '" + textBox_SPLP_Password.Text + "' where id = '" + textBox_SPLP_ID.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                int check = command.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Information Updated!");
                    textBox_SPLP_Name.Enabled = false;
                    textBox_SPLP_Email.Enabled = false;
                    textBox_SPLP_Address.Enabled = false;
                    textBox_SPLP_PhoneNo.Enabled = false;
                    textBox_SPLP_Password.Enabled = false;
                    button_SPLP_Update.Visible = true;
                    button_SPLP_UpdateOK.Visible = false;
                    button_SPLP_UpdateCancel.Visible = false;
                    label_SPLP_ConfirmPassword.Visible = false;
                    textBox_SPLP_ConfirmPassword.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error!\nTry Again.");

                }
                connection.Close();
            }
        }

        private void button_SPLP_Logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void button_SPLP_SearchUser_Click(object sender, EventArgs e)
        {
            button_SPLP_SearchUser.Visible = false;
            label_SPLP_SearchId.Visible = true;
            textBox_SPLP_SearchId.Visible = true;
            button_SPLP_SearchUserOK.Visible = true;
            button_SPLP_SearchUserCancel.Visible = true;
        }

        private void button_SPLP_SearchUserCancel_Click(object sender, EventArgs e)
        {
            textBox_SPLP_SearchId.Text = "";
            button_SPLP_SearchUser.Visible = true;
            label_SPLP_SearchId.Visible = false;
            textBox_SPLP_SearchId.Visible = false;
            button_SPLP_SearchUserOK.Visible = false;
            button_SPLP_SearchUserCancel.Visible = false;
        }

        private void button_SPLP_SearchUserOK_Click(object sender, EventArgs e)
        {
            

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            string sql = "select * from C_List where id= '" + textBox_SPLP_SearchId.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                textBox_SPLP_SUserId.Text = reader["id"].ToString();
                textBox_SPLP_SUserName.Text = reader["Name"].ToString();
                textBox_SPLP_SUserBalance.Text = reader["Balance"].ToString();
                textBox_SPLP_SUserDueBalance.Text = reader["DueBalance"].ToString();
                
                label_SPLP_SearchId.Visible = false;
                textBox_SPLP_SearchId.Visible = false;
                button_SPLP_SearchUserOK.Visible = false;
                button_SPLP_SearchUserCancel.Visible = false;
                groupBox_SPLP_UserInfo.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid ID!");
                textBox_SPLP_SearchId.Text = "";
            }
        }

        private void button_SPLP_SUserOK_Click(object sender, EventArgs e)
        {
            textBox_SPLP_SearchId.Text = "";
            button_SPLP_SearchUser.Visible = true;
            label_SPLP_SearchId.Visible = false;
            textBox_SPLP_SearchId.Visible = false;
            button_SPLP_SearchUserOK.Visible = false;
            button_SPLP_SearchUserCancel.Visible = false;
            groupBox_SPLP_UserInfo.Visible = false;
        }


        private void button_SPLP_SUserSetDB_Click(object sender, EventArgs e)
        {
            button_SPLP_SUserOK.Visible = false;
            button_SPLP_SUserSetDB.Visible = false;
            button_SPLP_SUserCancel.Visible = true;
            button_SPLP_SUserSet.Visible = true;
            label_SPLP_SUserDueBalanceAmount.Visible = true;
            textBox_SPLP_SUserDueBalanceAmount.Visible = true;
        }

        private void button_SPLP_SUserCancel_Click(object sender, EventArgs e)
        {
            textBox_SPLP_SUserDueBalanceAmount.Text = "";
            button_SPLP_SUserOK.Visible = true;
            button_SPLP_SUserSetDB.Visible = true;
            button_SPLP_SUserCancel.Visible = false;
            button_SPLP_SUserSet.Visible = false;
            label_SPLP_SUserDueBalanceAmount.Visible = false;
            textBox_SPLP_SUserDueBalanceAmount.Visible = false;
        }

        private void button_SPLP_SUserSet_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            int a = int.Parse(textBox_SPLP_SUserDueBalance.Text);
            int b = int.Parse(textBox_SPLP_SUserDueBalanceAmount.Text);
            int c = a + b;
            string sql = "UPDATE C_List SET DueBalance = '" + c.ToString() + "' where id = '" + textBox_SPLP_SUserId.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            int check = command.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Due Balance Set!");
                textBox_SPLP_SUserDueBalanceAmount.Text = "";
                button_SPLP_SUserOK.Visible = true;
                button_SPLP_SUserSetDB.Visible = true;
                button_SPLP_SUserCancel.Visible = false;
                button_SPLP_SUserSet.Visible = false;
                label_SPLP_SUserDueBalanceAmount.Visible = false;
                textBox_SPLP_SUserDueBalanceAmount.Visible = false;

            }
            else
            {
                MessageBox.Show("Error!\nTry Again.");

            }
            connection.Close();
        }

        private void SPLP_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            string sql = "Select * From C_List";
            SqlCommand command = new SqlCommand(sql, connection);
            List<CList> cLists = new List<CList>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CList cList = new CList();
                cList.ID = (int)reader["id"];
                cList.Username = reader["Username"].ToString();
                cList.Name = reader["Name"].ToString();
                cList.DateOfBirth = reader["DateOfBirth"].ToString();
                cList.Address = reader["Address"].ToString();
                cList.Email = reader["Email"].ToString();
                cList.Password = reader["Password"].ToString();
                cList.Balance = reader["Balance"].ToString();
                cList.DueBalance = reader["DueBalance"].ToString();
                cLists.Add(cList);
            }
            connection.Close();
            dataGridView_SPLP_CList.DataSource = cLists;
        }

        private void dataGridView_SPLP_CList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_SPLP_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_SPLP_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
