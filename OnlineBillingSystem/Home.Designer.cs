
namespace OnlineBillingSystem
{
    partial class Home
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
            this.button_HP_Login = new System.Windows.Forms.Button();
            this.button_HP_Signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_HP_Login
            // 
            this.button_HP_Login.Location = new System.Drawing.Point(510, 131);
            this.button_HP_Login.Name = "button_HP_Login";
            this.button_HP_Login.Size = new System.Drawing.Size(75, 23);
            this.button_HP_Login.TabIndex = 0;
            this.button_HP_Login.Text = "Login";
            this.button_HP_Login.UseVisualStyleBackColor = true;
            this.button_HP_Login.Click += new System.EventHandler(this.button_HP_Login_Click);
            // 
            // button_HP_Signup
            // 
            this.button_HP_Signup.Location = new System.Drawing.Point(510, 176);
            this.button_HP_Signup.Name = "button_HP_Signup";
            this.button_HP_Signup.Size = new System.Drawing.Size(75, 23);
            this.button_HP_Signup.TabIndex = 1;
            this.button_HP_Signup.Text = "Sign Up";
            this.button_HP_Signup.UseVisualStyleBackColor = true;
            this.button_HP_Signup.Click += new System.EventHandler(this.button_HP_Signup_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 641);
            this.Controls.Add(this.button_HP_Signup);
            this.Controls.Add(this.button_HP_Login);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_HP_Login;
        private System.Windows.Forms.Button button_HP_Signup;
    }
}

