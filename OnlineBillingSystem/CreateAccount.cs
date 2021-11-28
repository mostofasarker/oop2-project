using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBillingSystem
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_CA_ServiceProvider_Click(object sender, EventArgs e)
        {
            SP_CAccount sP_CAccount = new SP_CAccount();
            this.Hide();
            sP_CAccount.Show();
        }

        private void buttonCA_Consumer_Click(object sender, EventArgs e)
        {
            C_CAccount c_CAccount = new C_CAccount();
            this.Hide();
            c_CAccount.Show();
        }

        private void buttonCA_Cancel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
