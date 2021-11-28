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
    public partial class SearchSPPage : Form
    {
        ALP aLP;
        public SearchSPPage(ALP aLP)
        {
            InitializeComponent();
            this.aLP = aLP;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            string sql = "select * from SP_List where id= '" + aLP.textBox_ALP_SID.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            {
                textBox_SSPP_ID.Text = reader["id"].ToString();
                textBox_SSPP_Name.Text = reader["SPName"].ToString();
                textBox_SSPP_Email.Text = reader["Email"].ToString();
                textBox_SSPP_Address.Text = reader["Address"].ToString();
                textBox_SSPP_PhoneNo.Text = reader["PhoneNumber"].ToString();
            }
        }

        private void SearchSPPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_SSPP_OK_Click(object sender, EventArgs e)
        {
            ALP aLP = new ALP();
            this.Hide();
            aLP.Show();
        }

        private void button_SSPP_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
                connection.Open();
                string sql = "DELETE FROM SP_List WHERE id = '" + aLP.textBox_ALP_SID.Text + "'";
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

        private void textBox_SSPP_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
