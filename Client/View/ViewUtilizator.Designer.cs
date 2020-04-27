using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Client.View
{
    partial class ViewUtilizator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.animaleB = new System.Windows.Forms.Button();
            this.filtrareB = new System.Windows.Forms.Button();
            this.filtrareC = new System.Windows.Forms.ComboBox();
            this.cautareB = new System.Windows.Forms.Button();
            this.statisticiC = new System.Windows.Forms.ComboBox();
            this.statisticiB = new System.Windows.Forms.Button();
            this.statisticiChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.angajatB = new System.Windows.Forms.Button();
            this.administratorB = new System.Windows.Forms.Button();
            this.specificatieC = new System.Windows.Forms.ComboBox();
            this.specieC = new System.Windows.Forms.ComboBox();
            this.resultArea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.statisticiChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultArea)).BeginInit();
            this.SuspendLayout();
            // 
            // animaleB
            // 
            this.animaleB.Location = new System.Drawing.Point(33, 12);
            this.animaleB.Name = "animaleB";
            this.animaleB.Size = new System.Drawing.Size(163, 32);
            this.animaleB.TabIndex = 0;
            this.animaleB.Text = "Animale";
            this.animaleB.UseVisualStyleBackColor = true;
            // 
            // filtrareB
            // 
            this.filtrareB.Location = new System.Drawing.Point(33, 146);
            this.filtrareB.Name = "filtrareB";
            this.filtrareB.Size = new System.Drawing.Size(163, 36);
            this.filtrareB.TabIndex = 1;
            this.filtrareB.Text = "Filtrare";
            this.filtrareB.UseVisualStyleBackColor = true;
            // 
            // filtrareC
            // 
            this.filtrareC.FormattingEnabled = true;
            this.filtrareC.Items.AddRange(new object[] {
            "Zona de habitat",
            "Tip alimentatie",
            "Tip locomotie",
            "Zona gradina zoologica"});
            this.filtrareC.Location = new System.Drawing.Point(33, 65);
            this.filtrareC.Name = "filtrareC";
            this.filtrareC.Size = new System.Drawing.Size(163, 21);
            this.filtrareC.TabIndex = 2;
            this.filtrareC.Text = "Filtrare dupa";
            // 
            // cautareB
            // 
            this.cautareB.Location = new System.Drawing.Point(33, 242);
            this.cautareB.Name = "cautareB";
            this.cautareB.Size = new System.Drawing.Size(163, 36);
            this.cautareB.TabIndex = 4;
            this.cautareB.Text = "Cautare";
            this.cautareB.UseVisualStyleBackColor = true;
            // 
            // statisticiC
            // 
            this.statisticiC.FormattingEnabled = true;
            this.statisticiC.Items.AddRange(new object[] {
            "Zona habitat",
            "Tip alimentatie",
            "Tip locomotie",
            ""});
            this.statisticiC.Location = new System.Drawing.Point(33, 306);
            this.statisticiC.Name = "statisticiC";
            this.statisticiC.Size = new System.Drawing.Size(163, 21);
            this.statisticiC.TabIndex = 5;
            this.statisticiC.Text = "Statistici";
            // 
            // statisticiB
            // 
            this.statisticiB.Location = new System.Drawing.Point(33, 360);
            this.statisticiB.Name = "statisticiB";
            this.statisticiB.Size = new System.Drawing.Size(163, 36);
            this.statisticiB.TabIndex = 6;
            this.statisticiB.Text = "Vizualizare statistici";
            this.statisticiB.UseVisualStyleBackColor = true;
            // 
            // statisticiChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statisticiChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statisticiChart.Legends.Add(legend1);
            this.statisticiChart.Location = new System.Drawing.Point(231, 242);
            this.statisticiChart.Name = "statisticiChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.statisticiChart.Series.Add(series1);
            this.statisticiChart.Size = new System.Drawing.Size(529, 149);
            this.statisticiChart.TabIndex = 7;
            this.statisticiChart.Text = "chart1";
            // 
            // angajatB
            // 
            this.angajatB.Location = new System.Drawing.Point(310, 397);
            this.angajatB.Name = "angajatB";
            this.angajatB.Size = new System.Drawing.Size(107, 36);
            this.angajatB.TabIndex = 9;
            this.angajatB.Text = "Angajat";
            this.angajatB.UseVisualStyleBackColor = true;
            // 
            // administratorB
            // 
            this.administratorB.Location = new System.Drawing.Point(463, 397);
            this.administratorB.Name = "administratorB";
            this.administratorB.Size = new System.Drawing.Size(107, 36);
            this.administratorB.TabIndex = 10;
            this.administratorB.Text = "Administrator";
            this.administratorB.UseVisualStyleBackColor = true;
            // 
            // specificatieC
            // 
            this.specificatieC.FormattingEnabled = true;
            this.specificatieC.Location = new System.Drawing.Point(33, 102);
            this.specificatieC.Name = "specificatieC";
            this.specificatieC.Size = new System.Drawing.Size(163, 21);
            this.specificatieC.TabIndex = 13;
            this.specificatieC.Text = "Specificatie";
            // 
            // specieC
            // 
            this.specieC.FormattingEnabled = true;
            this.specieC.Location = new System.Drawing.Point(33, 188);
            this.specieC.Name = "specieC";
            this.specieC.Size = new System.Drawing.Size(163, 21);
            this.specieC.TabIndex = 14;
            this.specieC.Text = "Selectati specia";
            // 
            // resultArea
            // 
            this.resultArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultArea.Location = new System.Drawing.Point(231, 12);
            this.resultArea.Name = "resultArea";
            this.resultArea.Size = new System.Drawing.Size(529, 213);
            this.resultArea.TabIndex = 15;
            // 
            // ViewUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 455);
            this.Controls.Add(this.resultArea);
            this.Controls.Add(this.specieC);
            this.Controls.Add(this.specificatieC);
            this.Controls.Add(this.administratorB);
            this.Controls.Add(this.angajatB);
            this.Controls.Add(this.statisticiChart);
            this.Controls.Add(this.statisticiB);
            this.Controls.Add(this.statisticiC);
            this.Controls.Add(this.cautareB);
            this.Controls.Add(this.filtrareC);
            this.Controls.Add(this.filtrareB);
            this.Controls.Add(this.animaleB);
            this.Name = "ViewUtilizator";
            this.Text = "Gradina Zoologica";
            ((System.ComponentModel.ISupportInitialize)(this.statisticiChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button animaleB;
        private System.Windows.Forms.Button filtrareB;
        private System.Windows.Forms.Button cautareB;
        private System.Windows.Forms.Button statisticiB;
        private System.Windows.Forms.Button angajatB;
        private System.Windows.Forms.Button administratorB;
        private System.Windows.Forms.ComboBox filtrareC;
        private System.Windows.Forms.ComboBox statisticiC;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticiChart;

        public DataGridView getResultArea()
        {
            return resultArea;
        }
        public Button getAnimaleB()
        {
            return animaleB;
        }
        public Button getfiltrareB()
        {
            return filtrareB;
        }
        public Button getCautareB()
        {
            return cautareB;
        }
        public Button getStatisticiB()
        {
            return statisticiB;
        }
        public Button getAngajatB()
        {
            return angajatB;
        }
        public Button getAdministratorB()
        {
            return administratorB;
        }
        public ComboBox getFiltrareC()
        {
            return filtrareC;
        }

        public ComboBox getStatisticiC()
        {
            return statisticiC;
        }

        public Chart getStatisticiChart()
        {
            return statisticiChart;
        }

        public ComboBox getSpecieC()
        {
            return specieC;
        }
        public ComboBox getSpecificatieC()
        {
            return specificatieC;
        }


        private ComboBox specificatieC;
        private ComboBox specieC;
        private DataGridView resultArea;
    }
}