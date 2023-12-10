
namespace Tyuiu.KupriyanovEA.Sprint6.Task5.V10
{
    partial class FormMain
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
            this.panelUslovie = new System.Windows.Forms.Panel();
            this.buttonSpravka = new System.Windows.Forms.Button();
            this.buttonFIle_KUE = new System.Windows.Forms.Button();
            this.buttonStartCode_KUE = new System.Windows.Forms.Button();
            this.groupBoxUslovie = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.panelInputData = new System.Windows.Forms.Panel();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutputData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart_Kue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelUslovie.SuspendLayout();
            this.groupBoxUslovie.SuspendLayout();
            this.panelInputData.SuspendLayout();
            this.groupBoxOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Kue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUslovie
            // 
            this.panelUslovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelUslovie.Controls.Add(this.buttonSpravka);
            this.panelUslovie.Controls.Add(this.buttonFIle_KUE);
            this.panelUslovie.Controls.Add(this.buttonStartCode_KUE);
            this.panelUslovie.Controls.Add(this.groupBoxUslovie);
            this.panelUslovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUslovie.Location = new System.Drawing.Point(0, 0);
            this.panelUslovie.Name = "panelUslovie";
            this.panelUslovie.Size = new System.Drawing.Size(894, 100);
            this.panelUslovie.TabIndex = 0;
            // 
            // buttonSpravka
            // 
            this.buttonSpravka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpravka.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSpravka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpravka.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka.Location = new System.Drawing.Point(756, 25);
            this.buttonSpravka.Name = "buttonSpravka";
            this.buttonSpravka.Size = new System.Drawing.Size(132, 63);
            this.buttonSpravka.TabIndex = 9;
            this.buttonSpravka.Text = "Справка";
            this.buttonSpravka.UseVisualStyleBackColor = false;
            this.buttonSpravka.Click += new System.EventHandler(this.buttonSpravka_Click);
            // 
            // buttonFIle_KUE
            // 
            this.buttonFIle_KUE.BackColor = System.Drawing.Color.Blue;
            this.buttonFIle_KUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFIle_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFIle_KUE.Location = new System.Drawing.Point(618, 25);
            this.buttonFIle_KUE.Name = "buttonFIle_KUE";
            this.buttonFIle_KUE.Size = new System.Drawing.Size(132, 63);
            this.buttonFIle_KUE.TabIndex = 8;
            this.buttonFIle_KUE.Text = "Файл";
            this.buttonFIle_KUE.UseVisualStyleBackColor = false;
            this.buttonFIle_KUE.Click += new System.EventHandler(this.buttonFIle_KUE_Click);
            // 
            // buttonStartCode_KUE
            // 
            this.buttonStartCode_KUE.BackColor = System.Drawing.Color.Green;
            this.buttonStartCode_KUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartCode_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartCode_KUE.Location = new System.Drawing.Point(480, 25);
            this.buttonStartCode_KUE.Name = "buttonStartCode_KUE";
            this.buttonStartCode_KUE.Size = new System.Drawing.Size(132, 63);
            this.buttonStartCode_KUE.TabIndex = 7;
            this.buttonStartCode_KUE.Text = "Выполнить";
            this.buttonStartCode_KUE.UseVisualStyleBackColor = false;
            this.buttonStartCode_KUE.Click += new System.EventHandler(this.buttonStartCode_KUE_Click);
            // 
            // groupBoxUslovie
            // 
            this.groupBoxUslovie.Controls.Add(this.textBoxUslovie);
            this.groupBoxUslovie.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxUslovie.Location = new System.Drawing.Point(3, 3);
            this.groupBoxUslovie.Name = "groupBoxUslovie";
            this.groupBoxUslovie.Size = new System.Drawing.Size(471, 91);
            this.groupBoxUslovie.TabIndex = 0;
            this.groupBoxUslovie.TabStop = false;
            this.groupBoxUslovie.Text = "Условие";
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxUslovie.Location = new System.Drawing.Point(10, 22);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(461, 63);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = "Прочитать данные из файла InPutFileTask5V10.txt. Вывести в dataGridView. Дан спис" +
    "ок из чисел. Вывести все числа, не равные 0. Построить диаграмму по этим значени" +
    "ям.";
            // 
            // panelInputData
            // 
            this.panelInputData.BackColor = System.Drawing.Color.Silver;
            this.panelInputData.Controls.Add(this.groupBoxOutputData);
            this.panelInputData.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInputData.Location = new System.Drawing.Point(0, 100);
            this.panelInputData.Name = "panelInputData";
            this.panelInputData.Size = new System.Drawing.Size(200, 361);
            this.panelInputData.TabIndex = 1;
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.dataGridViewOutputData);
            this.groupBoxOutputData.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutputData.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(195, 361);
            this.groupBoxOutputData.TabIndex = 0;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Вывод данынх";
            // 
            // dataGridViewOutputData
            // 
            this.dataGridViewOutputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputData.ColumnHeadersVisible = false;
            this.dataGridViewOutputData.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewOutputData.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutputData.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewOutputData.Name = "dataGridViewOutputData";
            this.dataGridViewOutputData.RowHeadersVisible = false;
            this.dataGridViewOutputData.Size = new System.Drawing.Size(184, 342);
            this.dataGridViewOutputData.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.chart_Kue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 361);
            this.panel1.TabIndex = 2;
            // 
            // chart_Kue
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Kue.ChartAreas.Add(chartArea1);
            this.chart_Kue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Kue.Legends.Add(legend1);
            this.chart_Kue.Location = new System.Drawing.Point(0, 0);
            this.chart_Kue.Name = "chart_Kue";
            this.chart_Kue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Kue.Series.Add(series1);
            this.chart_Kue.Size = new System.Drawing.Size(694, 361);
            this.chart_Kue.TabIndex = 0;
            this.chart_Kue.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInputData);
            this.Controls.Add(this.panelUslovie);
            this.MinimumSize = new System.Drawing.Size(910, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 10 | Куприянов Е.А. ";
            this.panelUslovie.ResumeLayout(false);
            this.groupBoxUslovie.ResumeLayout(false);
            this.groupBoxUslovie.PerformLayout();
            this.panelInputData.ResumeLayout(false);
            this.groupBoxOutputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Kue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUslovie;
        private System.Windows.Forms.Panel panelInputData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxUslovie;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.Button buttonStartCode_KUE;
        private System.Windows.Forms.Button buttonFIle_KUE;
        private System.Windows.Forms.Button buttonSpravka;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.DataGridView dataGridViewOutputData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Kue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

