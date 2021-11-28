
namespace OnlineBillingSystem
{
    partial class CreateAccount
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
            this.button_CA_ServiceProvider = new System.Windows.Forms.Button();
            this.buttonCA_Consumer = new System.Windows.Forms.Button();
            this.buttonCA_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CA_ServiceProvider
            // 
            this.button_CA_ServiceProvider.Location = new System.Drawing.Point(425, 217);
            this.button_CA_ServiceProvider.Name = "button_CA_ServiceProvider";
            this.button_CA_ServiceProvider.Size = new System.Drawing.Size(165, 52);
            this.button_CA_ServiceProvider.TabIndex = 0;
            this.button_CA_ServiceProvider.Text = "Service Provider";
            this.button_CA_ServiceProvider.UseVisualStyleBackColor = true;
            this.button_CA_ServiceProvider.Click += new System.EventHandler(this.button_CA_ServiceProvider_Click);
            // 
            // buttonCA_Consumer
            // 
            this.buttonCA_Consumer.Location = new System.Drawing.Point(606, 217);
            this.buttonCA_Consumer.Name = "buttonCA_Consumer";
            this.buttonCA_Consumer.Size = new System.Drawing.Size(164, 52);
            this.buttonCA_Consumer.TabIndex = 1;
            this.buttonCA_Consumer.Text = "Consumer";
            this.buttonCA_Consumer.UseVisualStyleBackColor = true;
            this.buttonCA_Consumer.Click += new System.EventHandler(this.buttonCA_Consumer_Click);
            // 
            // buttonCA_Cancel
            // 
            this.buttonCA_Cancel.Location = new System.Drawing.Point(425, 275);
            this.buttonCA_Cancel.Name = "buttonCA_Cancel";
            this.buttonCA_Cancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCA_Cancel.TabIndex = 2;
            this.buttonCA_Cancel.Text = "Cancel";
            this.buttonCA_Cancel.UseVisualStyleBackColor = true;
            this.buttonCA_Cancel.Click += new System.EventHandler(this.buttonCA_Cancel_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 641);
            this.Controls.Add(this.buttonCA_Cancel);
            this.Controls.Add(this.buttonCA_Consumer);
            this.Controls.Add(this.button_CA_ServiceProvider);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signup_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CA_ServiceProvider;
        private System.Windows.Forms.Button buttonCA_Consumer;
        private System.Windows.Forms.Button buttonCA_Cancel;
    }
}