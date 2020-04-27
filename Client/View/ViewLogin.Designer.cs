using System.Windows.Forms;
namespace Client.View
{
    partial class ViewLogin
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unsername
            // 
            this.username.Location = new System.Drawing.Point(48, 44);
            this.username.Name = "unsername";
            this.username.Size = new System.Drawing.Size(151, 20);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(48, 88);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(151, 20);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(99, 151);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(75, 23);
            this.loginB.TabIndex = 2;
            this.loginB.Text = "Log in";
            this.loginB.UseVisualStyleBackColor = true;
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 222);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "ViewLogin";
            this.Text = "Log-in Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginB;
        public Button getLoginB()
        {
            return loginB;
        }
        public TextBox getUserName()
        {
            return username;
        }
        public TextBox getPassword()
        {
            return password;
        }

    }
}