
namespace OnlineBillingSystem
{
    partial class ALP
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
            this.textBox_ALP_Name = new System.Windows.Forms.TextBox();
            this.textBox_ALP_Password = new System.Windows.Forms.TextBox();
            this.label_ALP_Name = new System.Windows.Forms.Label();
            this.label_ALP_Pasword = new System.Windows.Forms.Label();
            this.dataGridView_ALP_SPList = new System.Windows.Forms.DataGridView();
            this.dataGridView_ALP_CList = new System.Windows.Forms.DataGridView();
            this.label_ALP_SPList = new System.Windows.Forms.Label();
            this.label_ALP_CList = new System.Windows.Forms.Label();
            this.comboBox_ALP_UserType = new System.Windows.Forms.ComboBox();
            this.textBox_ALP_SID = new System.Windows.Forms.TextBox();
            this.button_ALP_SearchUser = new System.Windows.Forms.Button();
            this.button_ALP_Search = new System.Windows.Forms.Button();
            this.button_ALP_Cancel = new System.Windows.Forms.Button();
            this.textBox_ALP_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label_ALP_ConfirmPasword = new System.Windows.Forms.Label();
            this.button_ALP_PasswordEdit = new System.Windows.Forms.Button();
            this.button_ALP_PasswordEditOk = new System.Windows.Forms.Button();
            this.button_ALP_PasswordEditCancel = new System.Windows.Forms.Button();
            this.button_ALP_Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ALP_SPList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ALP_CList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ALP_Name
            // 
            this.textBox_ALP_Name.Enabled = false;
            this.textBox_ALP_Name.Location = new System.Drawing.Point(158, 63);
            this.textBox_ALP_Name.Name = "textBox_ALP_Name";
            this.textBox_ALP_Name.Size = new System.Drawing.Size(148, 20);
            this.textBox_ALP_Name.TabIndex = 0;
            // 
            // textBox_ALP_Password
            // 
            this.textBox_ALP_Password.Location = new System.Drawing.Point(158, 100);
            this.textBox_ALP_Password.Name = "textBox_ALP_Password";
            this.textBox_ALP_Password.PasswordChar = '*';
            this.textBox_ALP_Password.Size = new System.Drawing.Size(148, 20);
            this.textBox_ALP_Password.TabIndex = 1;
            // 
            // label_ALP_Name
            // 
            this.label_ALP_Name.AutoSize = true;
            this.label_ALP_Name.Location = new System.Drawing.Point(34, 63);
            this.label_ALP_Name.Name = "label_ALP_Name";
            this.label_ALP_Name.Size = new System.Drawing.Size(35, 13);
            this.label_ALP_Name.TabIndex = 2;
            this.label_ALP_Name.Text = "Name";
            // 
            // label_ALP_Pasword
            // 
            this.label_ALP_Pasword.AutoSize = true;
            this.label_ALP_Pasword.Location = new System.Drawing.Point(34, 107);
            this.label_ALP_Pasword.Name = "label_ALP_Pasword";
            this.label_ALP_Pasword.Size = new System.Drawing.Size(53, 13);
            this.label_ALP_Pasword.TabIndex = 3;
            this.label_ALP_Pasword.Text = "Password";
            // 
            // dataGridView_ALP_SPList
            // 
            this.dataGridView_ALP_SPList.AllowUserToAddRows = false;
            this.dataGridView_ALP_SPList.AllowUserToDeleteRows = false;
            this.dataGridView_ALP_SPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ALP_SPList.Location = new System.Drawing.Point(12, 377);
            this.dataGridView_ALP_SPList.Name = "dataGridView_ALP_SPList";
            this.dataGridView_ALP_SPList.ReadOnly = true;
            this.dataGridView_ALP_SPList.Size = new System.Drawing.Size(591, 232);
            this.dataGridView_ALP_SPList.TabIndex = 4;
            // 
            // dataGridView_ALP_CList
            // 
            this.dataGridView_ALP_CList.AllowUserToAddRows = false;
            this.dataGridView_ALP_CList.AllowUserToDeleteRows = false;
            this.dataGridView_ALP_CList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ALP_CList.Location = new System.Drawing.Point(634, 377);
            this.dataGridView_ALP_CList.Name = "dataGridView_ALP_CList";
            this.dataGridView_ALP_CList.ReadOnly = true;
            this.dataGridView_ALP_CList.Size = new System.Drawing.Size(548, 232);
            this.dataGridView_ALP_CList.TabIndex = 5;
            // 
            // label_ALP_SPList
            // 
            this.label_ALP_SPList.AutoSize = true;
            this.label_ALP_SPList.Location = new System.Drawing.Point(13, 358);
            this.label_ALP_SPList.Name = "label_ALP_SPList";
            this.label_ALP_SPList.Size = new System.Drawing.Size(90, 13);
            this.label_ALP_SPList.TabIndex = 6;
            this.label_ALP_SPList.Text = "Service Providers";
            // 
            // label_ALP_CList
            // 
            this.label_ALP_CList.AutoSize = true;
            this.label_ALP_CList.Location = new System.Drawing.Point(634, 357);
            this.label_ALP_CList.Name = "label_ALP_CList";
            this.label_ALP_CList.Size = new System.Drawing.Size(59, 13);
            this.label_ALP_CList.TabIndex = 7;
            this.label_ALP_CList.Text = "Consumers";
            // 
            // comboBox_ALP_UserType
            // 
            this.comboBox_ALP_UserType.FormattingEnabled = true;
            this.comboBox_ALP_UserType.Items.AddRange(new object[] {
            "Service Provider",
            "Consumer"});
            this.comboBox_ALP_UserType.Location = new System.Drawing.Point(634, 99);
            this.comboBox_ALP_UserType.Name = "comboBox_ALP_UserType";
            this.comboBox_ALP_UserType.Size = new System.Drawing.Size(74, 21);
            this.comboBox_ALP_UserType.TabIndex = 8;
            this.comboBox_ALP_UserType.Text = "User Type";
            // 
            // textBox_ALP_SID
            // 
            this.textBox_ALP_SID.Location = new System.Drawing.Point(714, 99);
            this.textBox_ALP_SID.Name = "textBox_ALP_SID";
            this.textBox_ALP_SID.Size = new System.Drawing.Size(161, 20);
            this.textBox_ALP_SID.TabIndex = 9;
            // 
            // button_ALP_SearchUser
            // 
            this.button_ALP_SearchUser.Location = new System.Drawing.Point(634, 59);
            this.button_ALP_SearchUser.Name = "button_ALP_SearchUser";
            this.button_ALP_SearchUser.Size = new System.Drawing.Size(241, 23);
            this.button_ALP_SearchUser.TabIndex = 11;
            this.button_ALP_SearchUser.Text = "Search User";
            this.button_ALP_SearchUser.UseVisualStyleBackColor = true;
            this.button_ALP_SearchUser.Click += new System.EventHandler(this.button_ALP_SearchUser_Click);
            // 
            // button_ALP_Search
            // 
            this.button_ALP_Search.Location = new System.Drawing.Point(802, 125);
            this.button_ALP_Search.Name = "button_ALP_Search";
            this.button_ALP_Search.Size = new System.Drawing.Size(73, 23);
            this.button_ALP_Search.TabIndex = 12;
            this.button_ALP_Search.Text = "Search";
            this.button_ALP_Search.UseVisualStyleBackColor = true;
            this.button_ALP_Search.Click += new System.EventHandler(this.button_ALP_Search_Click);
            // 
            // button_ALP_Cancel
            // 
            this.button_ALP_Cancel.Location = new System.Drawing.Point(714, 125);
            this.button_ALP_Cancel.Name = "button_ALP_Cancel";
            this.button_ALP_Cancel.Size = new System.Drawing.Size(73, 23);
            this.button_ALP_Cancel.TabIndex = 13;
            this.button_ALP_Cancel.Text = "Cancel";
            this.button_ALP_Cancel.UseVisualStyleBackColor = true;
            this.button_ALP_Cancel.Click += new System.EventHandler(this.button_ALP_Cancel_Click);
            // 
            // textBox_ALP_ConfirmPassword
            // 
            this.textBox_ALP_ConfirmPassword.Location = new System.Drawing.Point(158, 137);
            this.textBox_ALP_ConfirmPassword.Name = "textBox_ALP_ConfirmPassword";
            this.textBox_ALP_ConfirmPassword.PasswordChar = '*';
            this.textBox_ALP_ConfirmPassword.Size = new System.Drawing.Size(148, 20);
            this.textBox_ALP_ConfirmPassword.TabIndex = 1;
            // 
            // label_ALP_ConfirmPasword
            // 
            this.label_ALP_ConfirmPasword.AutoSize = true;
            this.label_ALP_ConfirmPasword.Location = new System.Drawing.Point(34, 144);
            this.label_ALP_ConfirmPasword.Name = "label_ALP_ConfirmPasword";
            this.label_ALP_ConfirmPasword.Size = new System.Drawing.Size(91, 13);
            this.label_ALP_ConfirmPasword.TabIndex = 3;
            this.label_ALP_ConfirmPasword.Text = "Confirm Password";
            // 
            // button_ALP_PasswordEdit
            // 
            this.button_ALP_PasswordEdit.Location = new System.Drawing.Point(312, 100);
            this.button_ALP_PasswordEdit.Name = "button_ALP_PasswordEdit";
            this.button_ALP_PasswordEdit.Size = new System.Drawing.Size(52, 20);
            this.button_ALP_PasswordEdit.TabIndex = 14;
            this.button_ALP_PasswordEdit.Text = "Edit";
            this.button_ALP_PasswordEdit.UseVisualStyleBackColor = true;
            this.button_ALP_PasswordEdit.Click += new System.EventHandler(this.button_ALP_PasswordEdit_Click);
            // 
            // button_ALP_PasswordEditOk
            // 
            this.button_ALP_PasswordEditOk.Location = new System.Drawing.Point(247, 163);
            this.button_ALP_PasswordEditOk.Name = "button_ALP_PasswordEditOk";
            this.button_ALP_PasswordEditOk.Size = new System.Drawing.Size(59, 23);
            this.button_ALP_PasswordEditOk.TabIndex = 15;
            this.button_ALP_PasswordEditOk.Text = "OK";
            this.button_ALP_PasswordEditOk.UseVisualStyleBackColor = true;
            this.button_ALP_PasswordEditOk.Click += new System.EventHandler(this.button_ALP_PasswordEditOk_Click);
            // 
            // button_ALP_PasswordEditCancel
            // 
            this.button_ALP_PasswordEditCancel.Location = new System.Drawing.Point(182, 163);
            this.button_ALP_PasswordEditCancel.Name = "button_ALP_PasswordEditCancel";
            this.button_ALP_PasswordEditCancel.Size = new System.Drawing.Size(59, 23);
            this.button_ALP_PasswordEditCancel.TabIndex = 16;
            this.button_ALP_PasswordEditCancel.Text = "Cancel";
            this.button_ALP_PasswordEditCancel.UseVisualStyleBackColor = true;
            this.button_ALP_PasswordEditCancel.Click += new System.EventHandler(this.button_ALP_PasswordEditCancel_Click);
            // 
            // button_ALP_Logout
            // 
            this.button_ALP_Logout.Location = new System.Drawing.Point(37, 186);
            this.button_ALP_Logout.Name = "button_ALP_Logout";
            this.button_ALP_Logout.Size = new System.Drawing.Size(75, 23);
            this.button_ALP_Logout.TabIndex = 17;
            this.button_ALP_Logout.Text = "Log Out";
            this.button_ALP_Logout.UseVisualStyleBackColor = true;
            this.button_ALP_Logout.Click += new System.EventHandler(this.button_ALP_Logout_Click);
            // 
            // ALP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 641);
            this.Controls.Add(this.button_ALP_Logout);
            this.Controls.Add(this.button_ALP_PasswordEditCancel);
            this.Controls.Add(this.button_ALP_PasswordEditOk);
            this.Controls.Add(this.button_ALP_PasswordEdit);
            this.Controls.Add(this.button_ALP_Cancel);
            this.Controls.Add(this.button_ALP_Search);
            this.Controls.Add(this.button_ALP_SearchUser);
            this.Controls.Add(this.textBox_ALP_SID);
            this.Controls.Add(this.comboBox_ALP_UserType);
            this.Controls.Add(this.label_ALP_CList);
            this.Controls.Add(this.label_ALP_SPList);
            this.Controls.Add(this.dataGridView_ALP_CList);
            this.Controls.Add(this.dataGridView_ALP_SPList);
            this.Controls.Add(this.label_ALP_ConfirmPasword);
            this.Controls.Add(this.label_ALP_Pasword);
            this.Controls.Add(this.textBox_ALP_ConfirmPassword);
            this.Controls.Add(this.label_ALP_Name);
            this.Controls.Add(this.textBox_ALP_Password);
            this.Controls.Add(this.textBox_ALP_Name);
            this.Name = "ALP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ALP_FormClosing);
            this.Load += new System.EventHandler(this.ALP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ALP_SPList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ALP_CList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ALP_Name;
        private System.Windows.Forms.TextBox textBox_ALP_Password;
        private System.Windows.Forms.Label label_ALP_Name;
        private System.Windows.Forms.Label label_ALP_Pasword;
        private System.Windows.Forms.DataGridView dataGridView_ALP_SPList;
        private System.Windows.Forms.DataGridView dataGridView_ALP_CList;
        private System.Windows.Forms.Label label_ALP_SPList;
        private System.Windows.Forms.Label label_ALP_CList;
        private System.Windows.Forms.ComboBox comboBox_ALP_UserType;
        public System.Windows.Forms.TextBox textBox_ALP_SID;
        private System.Windows.Forms.Button button_ALP_SearchUser;
        private System.Windows.Forms.Button button_ALP_Search;
        private System.Windows.Forms.Button button_ALP_Cancel;
        private System.Windows.Forms.TextBox textBox_ALP_ConfirmPassword;
        private System.Windows.Forms.Label label_ALP_ConfirmPasword;
        private System.Windows.Forms.Button button_ALP_PasswordEdit;
        private System.Windows.Forms.Button button_ALP_PasswordEditOk;
        private System.Windows.Forms.Button button_ALP_PasswordEditCancel;
        private System.Windows.Forms.Button button_ALP_Logout;
    }
}