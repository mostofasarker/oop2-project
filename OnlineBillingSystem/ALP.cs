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
    public partial class ALP : Form
    {
        public ALP()
        {
            InitializeComponent();
            //Password Edit
            label_ALP_ConfirmPasword.Visible = false;
            textBox_ALP_Password.Enabled = false;
            textBox_ALP_ConfirmPassword.Visible = false;
            button_ALP_PasswordEdit.Visible = true;
            button_ALP_PasswordEditCancel.Visible = false;
            button_ALP_PasswordEditOk.Visible = false;

            //User Search
            comboBox_ALP_UserType.Visible = false;
            textBox_ALP_SID.Visible = false;
            button_ALP_Search.Visible = false;
            button_ALP_Cancel.Visible = false;


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            string sql = "select * from Admin";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            {
                textBox_ALP_Name.Text = reader["Username"].ToString();
                textBox_ALP_Password.Text = reader["Password"].ToString();
            }
        }

        private void ALP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ALP_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            string sql_1 = "Select * From SP_List";
            SqlCommand command_1 = new SqlCommand(sql_1, connection);
            List<SPList> sPLists = new List<SPList>();
            SqlDataReader reader_1 = command_1.ExecuteReader();
            while (reader_1.Read())
            {
                SPList sPList = new SPList();
                sPList.ID = (int)reader_1["id"];
                sPList.SPName = reader_1["SPName"].ToString();
                sPList.Email = reader_1["Email"].ToString();
                sPList.Address = reader_1["Address"].ToString();
                sPList.PhoneNumber = reader_1["PhoneNumber"].ToString();
                sPList.Password = reader_1["Password"].ToString();
                sPLists.Add(sPList);
            }
            connection.Close();
            dataGridView_ALP_SPList.DataSource = sPLists;

            connection.Open();
            string sql_2 = "Select * From C_List";
            SqlCommand command_2 = new SqlCommand(sql_2, connection);
            List<CList> cLists = new List<CList>();
            SqlDataReader reader_2 = command_2.ExecuteReader();
            while (reader_2.Read())
            {
                CList cList = new CList();
                cList.ID = (int)reader_2["id"];
                cList.Username = reader_2["Username"].ToString();
                cList.Name = reader_2["Name"].ToString();
                cList.DateOfBirth = reader_2["DateOfBirth"].ToString();
                cList.Address = reader_2["Address"].ToString();
                cList.Email = reader_2["Email"].ToString();
                cList.Password = reader_2["Password"].ToString();
                cList.Balance = reader_2["Balance"].ToString();
                cList.DueBalance = reader_2["DueBalance"].ToString();
                cLists.Add(cList);
            }
            connection.Close();
            dataGridView_ALP_CList.DataSource = cLists;
        }

        private void button_ALP_SearchUser_Click(object sender, EventArgs e)
        {
            button_ALP_SearchUser.Visible = false;
            comboBox_ALP_UserType.Visible = true;
            textBox_ALP_SID.Visible = true;
            button_ALP_Search.Visible = true;
            button_ALP_Cancel.Visible = true;
        }

        private void button_ALP_Cancel_Click(object sender, EventArgs e)
        {
            comboBox_ALP_UserType.Visible = false;
            textBox_ALP_SID.Visible = false;
            button_ALP_Search.Visible = false;
            button_ALP_Cancel.Visible = false;
            button_ALP_SearchUser.Visible = true;
        }

        private void button_ALP_Search_Click(object sender, EventArgs e)
        {
            if(comboBox_ALP_UserType.Text == "Service Provider")
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
                connection.Open();
                string sql = "select * from SP_List where id= '" + textBox_ALP_SID.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    SearchSPPage searchSPPage = new SearchSPPage(this);
                    this.Hide();
                    searchSPPage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid ID!");
                }
                
            }
            else if (comboBox_ALP_UserType.Text == "Consumer")
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
                connection.Open();
                string sql = "select * from C_List where id= '" + textBox_ALP_SID.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    SearchCPage searchCPage = new SearchCPage(this);
                    this.Hide();
                    searchCPage.Show();
                }

                else
                {
                    MessageBox.Show("Invalid ID!");
                }
            }
            else
            {
                MessageBox.Show("Select User Type!");
            }
        }

        private void button_ALP_PasswordEdit_Click(object sender, EventArgs e)
        {
            label_ALP_Pasword.Text = "New Password";
            label_ALP_ConfirmPasword.Visible = true;
            textBox_ALP_Password.Enabled = true;
            textBox_ALP_ConfirmPassword.Visible = true;
            button_ALP_PasswordEdit.Visible = false;
            button_ALP_PasswordEditCancel.Visible = true;
            button_ALP_PasswordEditOk.Visible = true;
        }

        private void button_ALP_PasswordEditCancel_Click(object sender, EventArgs e)
        {
            label_ALP_Pasword.Text = "Password";
            label_ALP_ConfirmPasword.Visible = false;
            textBox_ALP_Password.Enabled = false;
            textBox_ALP_ConfirmPassword.Visible = false;
            button_ALP_PasswordEdit.Visible = true;
            button_ALP_PasswordEditCancel.Visible = false;
            button_ALP_PasswordEditOk.Visible = false;
        }

        private void button_ALP_PasswordEditOk_Click(object sender, EventArgs e)
        {
            if (textBox_ALP_Password.Text == "")
            {
                MessageBox.Show("Input a Password!");
            }
            else if (textBox_ALP_ConfirmPassword.Text != textBox_ALP_Password.Text)
            {
                MessageBox.Show("Passwords Do not Match!");
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
                connection.Open();
                string sql = "UPDATE Admin SET Password ='" + textBox_ALP_ConfirmPassword.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                int check = command.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Password Changed!");
                    label_ALP_Pasword.Text = "Password";
                    label_ALP_ConfirmPasword.Visible = false;
                    textBox_ALP_Password.Enabled = false;
                    textBox_ALP_ConfirmPassword.Visible = false;
                    button_ALP_PasswordEdit.Visible = true;
                    button_ALP_PasswordEditCancel.Visible = false;
                    button_ALP_PasswordEditOk.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error!\nTry Again.");

                }
                connection.Close();
            }
        }

        private void button_ALP_Logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
