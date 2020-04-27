using System.Windows.Forms;
namespace Client.View
{
    partial class ViewAngajat
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
            this.animal = new System.Windows.Forms.TextBox();
            this.addAnimalB = new System.Windows.Forms.Button();
            this.updateAnimalB = new System.Windows.Forms.Button();
            this.deleteAnimalB = new System.Windows.Forms.Button();
            this.logoutB = new System.Windows.Forms.Button();
            this.specie = new System.Windows.Forms.TextBox();
            this.zonaHabitat = new System.Windows.Forms.TextBox();
            this.tipAlimentatie = new System.Windows.Forms.TextBox();
            this.tipLocomotie = new System.Windows.Forms.TextBox();
            this.zonaZoo = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.raportC = new System.Windows.Forms.ComboBox();
            this.raportB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animal
            // 
            this.animal.Location = new System.Drawing.Point(40, 59);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(140, 20);
            this.animal.TabIndex = 0;
            // 
            // addAnimalB
            // 
            this.addAnimalB.Location = new System.Drawing.Point(303, 39);
            this.addAnimalB.Name = "addAnimalB";
            this.addAnimalB.Size = new System.Drawing.Size(108, 40);
            this.addAnimalB.TabIndex = 6;
            this.addAnimalB.Text = "Adaugare animal";
            this.addAnimalB.UseVisualStyleBackColor = true;
            // 
            // updateAnimalB
            // 
            this.updateAnimalB.Location = new System.Drawing.Point(303, 107);
            this.updateAnimalB.Name = "updateAnimalB";
            this.updateAnimalB.Size = new System.Drawing.Size(108, 37);
            this.updateAnimalB.TabIndex = 7;
            this.updateAnimalB.Text = "Updatare animal";
            this.updateAnimalB.UseVisualStyleBackColor = true;
            // 
            // deleteAnimalB
            // 
            this.deleteAnimalB.Location = new System.Drawing.Point(303, 178);
            this.deleteAnimalB.Name = "deleteAnimalB";
            this.deleteAnimalB.Size = new System.Drawing.Size(108, 41);
            this.deleteAnimalB.TabIndex = 8;
            this.deleteAnimalB.Text = "Stergere animal";
            this.deleteAnimalB.UseVisualStyleBackColor = true;
            // 
            // logoutB
            // 
            this.logoutB.Location = new System.Drawing.Point(449, 249);
            this.logoutB.Name = "logoutB";
            this.logoutB.Size = new System.Drawing.Size(57, 26);
            this.logoutB.TabIndex = 9;
            this.logoutB.Text = "Log out";
            this.logoutB.UseVisualStyleBackColor = true;
            // 
            // specie
            // 
            this.specie.Location = new System.Drawing.Point(40, 95);
            this.specie.Name = "specie";
            this.specie.Size = new System.Drawing.Size(140, 20);
            this.specie.TabIndex = 10;
            // 
            // zonaHabitat
            // 
            this.zonaHabitat.Location = new System.Drawing.Point(40, 138);
            this.zonaHabitat.Name = "zonaHabitat";
            this.zonaHabitat.Size = new System.Drawing.Size(140, 20);
            this.zonaHabitat.TabIndex = 11;
            // 
            // tipAlimentatie
            // 
            this.tipAlimentatie.Location = new System.Drawing.Point(40, 178);
            this.tipAlimentatie.Name = "tipAlimentatie";
            this.tipAlimentatie.Size = new System.Drawing.Size(140, 20);
            this.tipAlimentatie.TabIndex = 12;
            // 
            // tipLocomotie
            // 
            this.tipLocomotie.Location = new System.Drawing.Point(40, 216);
            this.tipLocomotie.Name = "tipLocomotie";
            this.tipLocomotie.Size = new System.Drawing.Size(140, 20);
            this.tipLocomotie.TabIndex = 13;
            // 
            // zonaZoo
            // 
            this.zonaZoo.Location = new System.Drawing.Point(40, 259);
            this.zonaZoo.Name = "zonaZoo";
            this.zonaZoo.Size = new System.Drawing.Size(140, 20);
            this.zonaZoo.TabIndex = 14;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(40, 21);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(140, 20);
            this.id.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Animal ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Animal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Specie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Zona de habitat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tip alimentatie";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(199, 219);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 13);
            this.label.TabIndex = 21;
            this.label.Text = "Tip locomotie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Zona gradina zoologica";
            // 
            // raportC
            // 
            this.raportC.FormattingEnabled = true;
            this.raportC.Items.AddRange(new object[] {
            ".csv",
            ".xml",
            ".json"});
            this.raportC.Location = new System.Drawing.Point(449, 54);
            this.raportC.Name = "raportC";
            this.raportC.Size = new System.Drawing.Size(68, 21);
            this.raportC.TabIndex = 23;
            this.raportC.Text = "Tip raport";
            // 
            // raportB
            // 
            this.raportB.Location = new System.Drawing.Point(449, 93);
            this.raportB.Name = "raportB";
            this.raportB.Size = new System.Drawing.Size(58, 51);
            this.raportB.TabIndex = 24;
            this.raportB.Text = "Raport";
            this.raportB.UseVisualStyleBackColor = true;
            // 
            // ViewAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Controls.Add(this.raportB);
            this.Controls.Add(this.raportC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.zonaZoo);
            this.Controls.Add(this.tipLocomotie);
            this.Controls.Add(this.tipAlimentatie);
            this.Controls.Add(this.zonaHabitat);
            this.Controls.Add(this.specie);
            this.Controls.Add(this.logoutB);
            this.Controls.Add(this.deleteAnimalB);
            this.Controls.Add(this.updateAnimalB);
            this.Controls.Add(this.addAnimalB);
            this.Controls.Add(this.animal);
            this.Name = "ViewAngajat";
            this.Text = "Angajat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Button addAnimalB;
        private System.Windows.Forms.Button updateAnimalB;
        private System.Windows.Forms.Button deleteAnimalB;
        private System.Windows.Forms.Button logoutB;
        private Button raportB;
        private System.Windows.Forms.TextBox animal;
        private System.Windows.Forms.TextBox specie;
        private System.Windows.Forms.TextBox zonaHabitat;
        private System.Windows.Forms.TextBox tipAlimentatie;
        private System.Windows.Forms.TextBox tipLocomotie;
        private System.Windows.Forms.TextBox zonaZoo;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private ComboBox raportC;
        public TextBox getId()
        {
            return id;
        }
        public TextBox getAnimal()
        {
            return animal;
        }
        public TextBox getSpecie()
        {
            return specie;
        }
        public TextBox getZonaHabitat()
        {
            return zonaHabitat;
        }
        public TextBox getTipAlimentatie()
        {
            return tipAlimentatie;
        }
        public TextBox getTipLocomotie()
        {
            return tipLocomotie;
        }
        public TextBox getZonaZoo()
        {
            return zonaZoo;

        }
        public Button getAddB()
        {
            return addAnimalB;

        }
        public Button getUpdateB()
        {
            return updateAnimalB;

        }
        public Button getDeleteB()
        {
            return deleteAnimalB;

        }
        public Button getLogoutB()
        {
            return logoutB;

        }
        public Button getRaportB()
        {
            return raportB;
        }
        public ComboBox getRaportC()
        {
            return raportC;
        }


    }
}