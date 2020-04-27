using System.Windows.Forms;
namespace Client.View
{
    partial class ViewAdministrator
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
            this.nume = new System.Windows.Forms.TextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.nr_Telefon = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.addB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.logoutB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.resultArea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultArea)).BeginInit();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(48, 41);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 20);
            this.nume.TabIndex = 0;
            // 
            // prenume
            // 
            this.prenume.Location = new System.Drawing.Point(48, 72);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(100, 20);
            this.prenume.TabIndex = 1;
            // 
            // nr_Telefon
            // 
            this.nr_Telefon.Location = new System.Drawing.Point(48, 107);
            this.nr_Telefon.Name = "nr_Telefon";
            this.nr_Telefon.Size = new System.Drawing.Size(100, 20);
            this.nr_Telefon.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(48, 142);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 3;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(48, 183);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(48, 224);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 5;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(273, 41);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(108, 40);
            this.addB.TabIndex = 7;
            this.addB.Text = "Adaugare angajat";
            this.addB.UseVisualStyleBackColor = true;
            // 
            // updateB
            // 
            this.updateB.Location = new System.Drawing.Point(273, 107);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(108, 40);
            this.updateB.TabIndex = 8;
            this.updateB.Text = "Updatare angajat";
            this.updateB.UseVisualStyleBackColor = true;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(273, 172);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(108, 40);
            this.deleteB.TabIndex = 9;
            this.deleteB.Text = "Stergere angajat";
            this.deleteB.UseVisualStyleBackColor = true;
            // 
            // logoutB
            // 
            this.logoutB.Location = new System.Drawing.Point(781, 230);
            this.logoutB.Name = "logoutB";
            this.logoutB.Size = new System.Drawing.Size(57, 26);
            this.logoutB.TabIndex = 10;
            this.logoutB.Text = "Log out";
            this.logoutB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nr de telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(48, 6);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 11;
            // 
            // resultArea
            // 
            this.resultArea.AllowUserToAddRows = false;
            this.resultArea.AllowUserToDeleteRows = false;
            this.resultArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultArea.Location = new System.Drawing.Point(434, 12);
            this.resultArea.Name = "resultArea";
            this.resultArea.ReadOnly = true;
            this.resultArea.Size = new System.Drawing.Size(422, 200);
            this.resultArea.TabIndex = 19;
            // 
            // ViewAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 268);
            this.Controls.Add(this.resultArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.logoutB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nr_Telefon);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.nume);
            this.Name = "ViewAdministrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.resultArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox id;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox nr_Telefon;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button logoutB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DataGridView resultArea;
        public TextBox getID()
        {
            return id;
        }
        public TextBox getNume()
        {
            return nume;
        }
        public TextBox getPrenume()
        {
            return prenume;
        }
        public TextBox getNrTelefon()
        {
            return nr_Telefon;
        }
        public TextBox getEmai()
        {
            return email;
        }
        public TextBox getUsername()
        {
            return username;

        }
        public TextBox getPassword()
        {
            return password;
        }
        public Button getAddAngajatB()
        {
            return addB;
        }
        public Button getUpdateAngajatB()
        {
            return updateB;
        }
        public Button getDeleteAngajatB()
        {
            return deleteB;
        }
        public Button getLogoutB()
        {
            return logoutB;
        }
        public DataGridView getResultArea()
        {
            return resultArea;
        }

    }
}