
namespace OnlineBillingSystem
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_LP_Username = new System.Windows.Forms.Label();
            this.label_LP_Password = new System.Windows.Forms.Label();
            this.textBox_LP_Username = new System.Windows.Forms.TextBox();
            this.textBox_LP_Password = new System.Windows.Forms.TextBox();
            this.button_LP_Cancel = new System.Windows.Forms.Button();
            this.button_LP_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_LP_Username
            // 
            this.label_LP_Username.AutoSize = true;
            this.label_LP_Username.Location = new System.Drawing.Point(309, 113);
            this.label_LP_Username.Name = "label_LP_Username";
            this.label_LP_Username.Size = new System.Drawing.Size(55, 13);
            this.label_LP_Username.TabIndex = 0;
            this.label_LP_Username.Text = "Username";
            // 
            // label_LP_Password
            // 
            this.label_LP_Password.AutoSize = true;
            this.label_LP_Password.Location = new System.Drawing.Point(312, 156);
            this.label_LP_Password.Name = "label_LP_Password";
            this.label_LP_Password.Size = new System.Drawing.Size(53, 13);
            this.label_LP_Password.TabIndex = 1;
            this.label_LP_Password.Text = "Password";
            // 
            // textBox_LP_Username
            // 
            this.textBox_LP_Username.Location = new System.Drawing.Point(397, 113);
            this.textBox_LP_Username.Name = "textBox_LP_Username";
            this.textBox_LP_Username.Size = new System.Drawing.Size(176, 20);
            this.textBox_LP_Username.TabIndex = 2;
            // 
            // textBox_LP_Password
            // 
            this.textBox_LP_Password.Location = new System.Drawing.Point(397, 148);
            this.textBox_LP_Password.Name = "textBox_LP_Password";
            this.textBox_LP_Password.PasswordChar = '*';
            this.textBox_LP_Password.Size = new System.Drawing.Size(176, 20);
            this.textBox_LP_Password.TabIndex = 3;
            this.textBox_LP_Password.TextChanged += new System.EventHandler(this.textBox_LP_Password_TextChanged);
            // 
            // button_LP_Cancel
            // 
            this.button_LP_Cancel.Location = new System.Drawing.Point(417, 193);
            this.button_LP_Cancel.Name = "button_LP_Cancel";
            this.button_LP_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_LP_Cancel.TabIndex = 4;
            this.button_LP_Cancel.Text = "Cancel";
            this.button_LP_Cancel.UseVisualStyleBackColor = true;
            this.button_LP_Cancel.Click += new System.EventHandler(this.button_LP_Cancel_Click);
            // 
            // button_LP_Login
            // 
            this.button_LP_Login.Location = new System.Drawing.Point(498, 193);
            this.button_LP_Login.Name = "button_LP_Login";
            this.button_LP_Login.Size = new System.Drawing.Size(75, 23);
            this.button_LP_Login.TabIndex = 5;
            this.button_LP_Login.Text = "Login";
            this.button_LP_Login.UseVisualStyleBackColor = true;
            this.button_LP_Login.Click += new System.EventHandler(this.button_LP_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 641);
            this.Controls.Add(this.button_LP_Login);
            this.Controls.Add(this.button_LP_Cancel);
            this.Controls.Add(this.textBox_LP_Password);
            this.Controls.Add(this.textBox_LP_Username);
            this.Controls.Add(this.label_LP_Password);
            this.Controls.Add(this.label_LP_Username);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LP_Username;
        private System.Windows.Forms.Label label_LP_Password;
        public System.Windows.Forms.TextBox textBox_LP_Username;
        public System.Windows.Forms.TextBox textBox_LP_Password;
        private System.Windows.Forms.Button button_LP_Cancel;
        private System.Windows.Forms.Button button_LP_Login;
    }
}