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
    public partial class CLP : Form
    {
        Login login;
        public CLP(Login login)
        {
            InitializeComponent();
            this.login = login;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            string sql = "select * from C_List where Username= '" + login.textBox_LP_Username.Text + "' and Password = '" + login.textBox_LP_Password.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            {
                textBox_CLP_Id.Text = reader["id"].ToString();
                textBox_CLP_Name.Text = reader["Name"].ToString();
                textBox_CLP_Username.Text = reader["Username"].ToString();
                dateTimePicker_CLP_DoB.Text = reader["DateOfBirth"].ToString();
                textBox_CLP_Address.Text = reader["Address"].ToString();
                textBox_CLP_Email.Text = reader["Email"].ToString();
                textBox_CLP_Password.Text = reader["Password"].ToString();
            }
        }

        private void CLP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
