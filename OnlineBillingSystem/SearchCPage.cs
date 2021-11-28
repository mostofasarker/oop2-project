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
    public partial class SearchCPage : Form
    {
        ALP aLP;
        public SearchCPage(ALP aLP)
        {
            InitializeComponent();
            this.aLP = aLP;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            string sql = "select * from C_List where id= '" + aLP.textBox_ALP_SID.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            {
                textBox_SCP_ID.Text = reader["id"].ToString();
                textBox_SCP_Name.Text = reader["Name"].ToString();
                textBox_SCP_Username.Text = reader["Username"].ToString();
                dateTimePicker_SCP_DoB.Text = reader["DateOfBirth"].ToString();
                textBox_SCP_Address.Text = reader["Address"].ToString();
                textBox_SCP_Email.Text = reader["Email"].ToString();
            }
        }

        private void SearchCPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_SCP_OK_Click(object sender, EventArgs e)
        {
            ALP aLP = new ALP();
            this.Hide();
            aLP.Show();
        }

        private void button_SCP_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
                connection.Open();
                string sql = "DELETE FROM C_List WHERE id = '" + aLP.textBox_ALP_SID.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                int check = command.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("User Account Deleted!");
                    ALP aLP = new ALP();
                    this.Hide();
                    aLP.Show();
                }
                else
                {
                    MessageBox.Show("Error!\nTry Again.");

                }
                connection.Close();
            }

        }

        private void textBox_SCP_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_SCP_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_SCP_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_SCP_Address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



