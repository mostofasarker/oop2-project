
namespace OnlineBillingSystem
{
    partial class C_CAccount
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
            this.label_CCA_Name = new System.Windows.Forms.Label();
            this.label_CCA_Username = new System.Windows.Forms.Label();
            this.label_CCA_DoB = new System.Windows.Forms.Label();
            this.label_CCA_Address = new System.Windows.Forms.Label();
            this.label_CCA_Email = new System.Windows.Forms.Label();
            this.label_CCA_Password = new System.Windows.Forms.Label();
            this.label_CCA_ConfirmPassword = new System.Windows.Forms.Label();
            this.dateTimePickerCCA_DoB = new System.Windows.Forms.DateTimePicker();
            this.textBox_CCA_Name = new System.Windows.Forms.TextBox();
            this.textBox_CCA_Username = new System.Windows.Forms.TextBox();
            this.textBox_CCA_Address = new System.Windows.Forms.TextBox();
            this.textBox_CCA_Email = new System.Windows.Forms.TextBox();
            this.textBox_CCA_Password = new System.Windows.Forms.TextBox();
            this.textBox_CCA_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.button_CCA_Create = new System.Windows.Forms.Button();
            this.button_CCA_Cancel = new System.Windows.Forms.Button();
            this.checkBox_CCA_Confirmation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_CCA_Name
            // 
            this.label_CCA_Name.AutoSize = true;
            this.label_CCA_Name.Location = new System.Drawing.Point(145, 123);
            this.label_CCA_Name.Name = "label_CCA_Name";
            this.label_CCA_Name.Size = new System.Drawing.Size(35, 13);
            this.label_CCA_Name.TabIndex = 0;
            this.label_CCA_Name.Text = "Name";
            // 
            // label_CCA_Username
            // 
            this.label_CCA_Username.AutoSize = true;
            this.label_CCA_Username.Location = new System.Drawing.Point(145, 152);
            this.label_CCA_Username.Name = "label_CCA_Username";
            this.label_CCA_Username.Size = new System.Drawing.Size(55, 13);
            this.label_CCA_Username.TabIndex = 1;
            this.label_CCA_Username.Text = "Username";
            // 
            // label_CCA_DoB
            // 
            this.label_CCA_DoB.AutoSize = true;
            this.label_CCA_DoB.Location = new System.Drawing.Point(145, 189);
            this.label_CCA_DoB.Name = "label_CCA_DoB";
            this.label_CCA_DoB.Size = new System.Drawing.Size(68, 13);
            this.label_CCA_DoB.TabIndex = 2;
            this.label_CCA_DoB.Text = "Date Of Birth";
            // 
            // label_CCA_Address
            // 
            this.label_CCA_Address.AutoSize = true;
            this.label_CCA_Address.Location = new System.Drawing.Point(145, 229);
            this.label_CCA_Address.Name = "label_CCA_Address";
            this.label_CCA_Address.Size = new System.Drawing.Size(45, 13);
            this.label_CCA_Address.TabIndex = 3;
            this.label_CCA_Address.Text = "Address";
            // 
            // label_CCA_Email
            // 
            this.label_CCA_Email.AutoSize = true;
            this.label_CCA_Email.Location = new System.Drawing.Point(145, 266);
            this.label_CCA_Email.Name = "label_CCA_Email";
            this.label_CCA_Email.Size = new System.Drawing.Size(32, 13);
            this.label_CCA_Email.TabIndex = 4;
            this.label_CCA_Email.Text = "Email";
            // 
            // label_CCA_Password
            // 
            this.label_CCA_Password.AutoSize = true;
            this.label_CCA_Password.Location = new System.Drawing.Point(145, 295);
            this.label_CCA_Password.Name = "label_CCA_Password";
            this.label_CCA_Password.Size = new System.Drawing.Size(53, 13);
            this.label_CCA_Password.TabIndex = 5;
            this.label_CCA_Password.Text = "Password";
            // 
            // label_CCA_ConfirmPassword
            // 
            this.label_CCA_ConfirmPassword.AutoSize = true;
            this.label_CCA_ConfirmPassword.Location = new System.Drawing.Point(145, 329);
            this.label_CCA_ConfirmPassword.Name = "label_CCA_ConfirmPassword";
            this.label_CCA_ConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.label_CCA_ConfirmPassword.TabIndex = 6;
            this.label_CCA_ConfirmPassword.Text = "Confirm Password";
            // 
            // dateTimePickerCCA_DoB
            // 
            this.dateTimePickerCCA_DoB.Location = new System.Drawing.Point(349, 181);
            this.dateTimePickerCCA_DoB.MaxDate = new System.DateTime(2021, 4, 27, 0, 0, 0, 0);
            this.dateTimePickerCCA_DoB.Name = "dateTimePickerCCA_DoB";
            this.dateTimePickerCCA_DoB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCCA_DoB.TabIndex = 7;
            this.dateTimePickerCCA_DoB.Value = new System.DateTime(2021, 4, 27, 0, 0, 0, 0);
            // 
            // textBox_CCA_Name
            // 
            this.textBox_CCA_Name.Location = new System.Drawing.Point(349, 115);
            this.textBox_CCA_Name.Name = "textBox_CCA_Name";
            this.textBox_CCA_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_CCA_Name.TabIndex = 8;
            // 
            // textBox_CCA_Username
            // 
            this.textBox_CCA_Username.Location = new System.Drawing.Point(349, 144);
            this.textBox_CCA_Username.Name = "textBox_CCA_Username";
            this.textBox_CCA_Username.Size = new System.Drawing.Size(100, 20);
            this.textBox_CCA_Username.TabIndex = 9;
            this.textBox_CCA_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CCA_Username_KeyPress);
            // 
            // textBox_CCA_Address
            // 
            this.textBox_CCA_Address.Location = new System.Drawing.Point(349, 221);
            this.textBox_CCA_Address.Name = "textBox_CCA_Address";
            this.textBox_CCA_Address.Size = new System.Drawing.Size(100, 20);
            this.textBox_CCA_Address.TabIndex = 10;
            // 
            // textBox_CCA_Email
            // 
            this.textBox_CCA_Email.Location = new System.Drawing.Point(349, 258);
            this.textBox_CCA_Email.Name = "textBox_CCA_Email";
            this.textBox_CCA_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_CCA_Email.TabIndex = 11;
            // 
            // textBox_CCA_Password
            // 
            this.textBox_CCA_Password.Location = new System.Drawing.Point(349, 287);
            this.textBox_CCA_Password.Name = "textBox_CCA_Password";
            this.textBox_CCA_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_CCA_Password.TabIndex = 12;
            // 
            // textBox_CCA_ConfirmPassword
            // 
            this.textBox_CCA_ConfirmPassword.Location = new System.Drawing.Point(349, 321);
            this.textBox_CCA_ConfirmPassword.Name = "textBox_CCA_ConfirmPassword";
            this.textBox_CCA_ConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.textBox_CCA_ConfirmPassword.TabIndex = 13;
            // 
            // button_CCA_Create
            // 
            this.button_CCA_Create.Enabled = false;
            this.button_CCA_Create.Location = new System.Drawing.Point(148, 392);
            this.button_CCA_Create.Name = "button_CCA_Create";
            this.button_CCA_Create.Size = new System.Drawing.Size(75, 23);
            this.button_CCA_Create.TabIndex = 14;
            this.button_CCA_Create.Text = "Create";
            this.button_CCA_Create.UseVisualStyleBackColor = true;
            this.button_CCA_Create.Click += new System.EventHandler(this.button_CCA_Create_Click);
            // 
            // button_CCA_Cancel
            // 
            this.button_CCA_Cancel.Location = new System.Drawing.Point(229, 392);
            this.button_CCA_Cancel.Name = "button_CCA_Cancel";
            this.button_CCA_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_CCA_Cancel.TabIndex = 15;
            this.button_CCA_Cancel.Text = "Cancel";
            this.button_CCA_Cancel.UseVisualStyleBackColor = true;
            this.button_CCA_Cancel.Click += new System.EventHandler(this.button_CCA_Cancel_Click);
            // 
            // checkBox_CCA_Confirmation
            // 
            this.checkBox_CCA_Confirmation.AutoSize = true;
            this.checkBox_CCA_Confirmation.Location = new System.Drawing.Point(148, 369);
            this.checkBox_CCA_Confirmation.Name = "checkBox_CCA_Confirmation";
            this.checkBox_CCA_Confirmation.Size = new System.Drawing.Size(189, 17);
            this.checkBox_CCA_Confirmation.TabIndex = 16;
            this.checkBox_CCA_Confirmation.Text = "I agree to the terms and conditions";
            this.checkBox_CCA_Confirmation.UseVisualStyleBackColor = true;
            this.checkBox_CCA_Confirmation.CheckedChanged += new System.EventHandler(this.checkBox_CCA_Confirmation_CheckedChanged);
            // 
            // C_CAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 641);
            this.Controls.Add(this.checkBox_CCA_Confirmation);
            this.Controls.Add(this.button_CCA_Cancel);
            this.Controls.Add(this.button_CCA_Create);
            this.Controls.Add(this.textBox_CCA_ConfirmPassword);
            this.Controls.Add(this.textBox_CCA_Password);
            this.Controls.Add(this.textBox_CCA_Email);
            this.Controls.Add(this.textBox_CCA_Address);
            this.Controls.Add(this.textBox_CCA_Username);
            this.Controls.Add(this.textBox_CCA_Name);
            this.Controls.Add(this.dateTimePickerCCA_DoB);
            this.Controls.Add(this.label_CCA_ConfirmPassword);
            this.Controls.Add(this.label_CCA_Password);
            this.Controls.Add(this.label_CCA_Email);
            this.Controls.Add(this.label_CCA_Address);
            this.Controls.Add(this.label_CCA_DoB);
            this.Controls.Add(this.label_CCA_Username);
            this.Controls.Add(this.label_CCA_Name);
            this.Name = "C_CAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C_CAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.C_CAccount_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CCA_Name;
        private System.Windows.Forms.Label label_CCA_Username;
        private System.Windows.Forms.Label label_CCA_DoB;
        private System.Windows.Forms.Label label_CCA_Address;
        private System.Windows.Forms.Label label_CCA_Email;
        private System.Windows.Forms.Label label_CCA_Password;
        private System.Windows.Forms.Label label_CCA_ConfirmPassword;
        private System.Windows.Forms.DateTimePicker dateTimePickerCCA_DoB;
        private System.Windows.Forms.TextBox textBox_CCA_Name;
        private System.Windows.Forms.TextBox textBox_CCA_Username;
        private System.Windows.Forms.TextBox textBox_CCA_Address;
        private System.Windows.Forms.TextBox textBox_CCA_Email;
        private System.Windows.Forms.TextBox textBox_CCA_Password;
        private System.Windows.Forms.TextBox textBox_CCA_ConfirmPassword;
        private System.Windows.Forms.Button button_CCA_Create;
        private System.Windows.Forms.Button button_CCA_Cancel;
        private System.Windows.Forms.CheckBox checkBox_CCA_Confirmation;
    }
}