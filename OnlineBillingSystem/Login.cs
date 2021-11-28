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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_LP_Login_Click(object sender, EventArgs e)
        {
            string SPName = textBox_LP_Username.Text;
            SPName = SPName.Substring(0, 3);
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            if(textBox_LP_Username.Text == "Admin")
            {
                string sql = "select * from Admin where Username = '" + textBox_LP_Username.Text + "' and Password = '" + textBox_LP_Password.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ALP aLP = new ALP();
                    this.Hide();
                    aLP.Show();
                }
                else
                {
                    MessageBox.Show("Admin ID or Password Incorrect!");
                    textBox_LP_Username.Text = "";
                    textBox_LP_Password.Text = "";
                }
                connection.Close();
            }

            else if (SPName.Equals("SP-"))
            {
                string sql = "select * from SP_List where SPName = '" + textBox_LP_Username.Text + "' and Password = '" + textBox_LP_Password.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    SPLP sPLP = new SPLP(this);
                    this.Hide();
                    sPLP.Show();
                }
                else
                {
                    MessageBox.Show("SP ID or Password Incorrect!");
                    textBox_LP_Username.Text = "";
                    textBox_LP_Password.Text = "";
                }
                connection.Close();
            }

            else 
            {
                string sql = "select * from C_List where Username = '" + textBox_LP_Username.Text + "' and Password = '" + textBox_LP_Password.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CLP cLP = new CLP(this);
                    this.Hide();
                    cLP.Show();
                }
                else
                {
                    MessageBox.Show("ID or Password Incorrect!");
                    textBox_LP_Username.Text = "";
                    textBox_LP_Password.Text = "";
                }
                connection.Close();
            }

        }

        private void button_LP_Cancel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void textBox_LP_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
