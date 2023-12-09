
namespace Tyuiu.KupriyanovEA.Sprint6.Task4.V16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_KUE = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_KUE = new System.Windows.Forms.GroupBox();
            this.labelInputStopStep_KUE = new System.Windows.Forms.Label();
            this.labelInputStartStep_KUE = new System.Windows.Forms.Label();
            this.textBoxInputStopStep_KUE = new System.Windows.Forms.TextBox();
            this.textBoxInputStartStep_KUE = new System.Windows.Forms.TextBox();
            this.buttonStartCode_KUE = new System.Windows.Forms.Button();
            this.buttonSave_KUE = new System.Windows.Forms.Button();
            this.buttonSpravka = new System.Windows.Forms.Button();
            this.groupBoxOutputData_KUE = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.chart_KUE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_KUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInputData_KUE.SuspendLayout();
            this.groupBoxOutputData_KUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_KUE)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KUE
            // 
            this.groupBoxTask_KUE.Controls.Add(this.pictureBox1);
            this.groupBoxTask_KUE.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_KUE.Location = new System.Drawing.Point(10, 10);
            this.groupBoxTask_KUE.Name = "groupBoxTask_KUE";
            this.groupBoxTask_KUE.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_KUE.Size = new System.Drawing.Size(509, 84);
            this.groupBoxTask_KUE.TabIndex = 2;
            this.groupBoxTask_KUE.TabStop = false;
            this.groupBoxTask_KUE.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Location = new System.Drawing.Point(6, 17);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(497, 61);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = "Протабулироавать функцию:\r\n\r\nна заданном диапазоне. Результат вывести в TextBox, " +
    "построить график функции и сохранить в файл OutPutFileTask4V16.txt по нажатию кн" +
    "опки.";
            // 
            // groupBoxInputData_KUE
            // 
            this.groupBoxInputData_KUE.Controls.Add(this.labelInputStopStep_KUE);
            this.groupBoxInputData_KUE.Controls.Add(this.labelInputStartStep_KUE);
            this.groupBoxInputData_KUE.Controls.Add(this.textBoxInputStopStep_KUE);
            this.groupBoxInputData_KUE.Controls.Add(this.textBoxInputStartStep_KUE);
            this.groupBoxInputData_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_KUE.Location = new System.Drawing.Point(534, 10);
            this.groupBoxInputData_KUE.Name = "groupBoxInputData_KUE";
            this.groupBoxInputData_KUE.Size = new System.Drawing.Size(256, 84);
            this.groupBoxInputData_KUE.TabIndex = 4;
            this.groupBoxInputData_KUE.TabStop = false;
            this.groupBoxInputData_KUE.Text = "Ввод данных";
            // 
            // labelInputStopStep_KUE
            // 
            this.labelInputStopStep_KUE.AutoSize = true;
            this.labelInputStopStep_KUE.Location = new System.Drawing.Point(131, 38);
            this.labelInputStopStep_KUE.Name = "labelInputStopStep_KUE";
            this.labelInputStopStep_KUE.Size = new System.Drawing.Size(76, 15);
            this.labelInputStopStep_KUE.TabIndex = 3;
            this.labelInputStopStep_KUE.Text = "Конец шага:";
            // 
            // labelInputStartStep_KUE
            // 
            this.labelInputStartStep_KUE.AutoSize = true;
            this.labelInputStartStep_KUE.Location = new System.Drawing.Point(6, 38);
            this.labelInputStartStep_KUE.Name = "labelInputStartStep_KUE";
            this.labelInputStartStep_KUE.Size = new System.Drawing.Size(75, 15);
            this.labelInputStartStep_KUE.TabIndex = 2;
            this.labelInputStartStep_KUE.Text = "Старт шага:";
            // 
            // textBoxInputStopStep_KUE
            // 
            this.textBoxInputStopStep_KUE.Location = new System.Drawing.Point(134, 56);
            this.textBoxInputStopStep_KUE.Name = "textBoxInputStopStep_KUE";
            this.textBoxInputStopStep_KUE.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputStopStep_KUE.TabIndex = 1;
            // 
            // textBoxInputStartStep_KUE
            // 
            this.textBoxInputStartStep_KUE.Location = new System.Drawing.Point(6, 56);
            this.textBoxInputStartStep_KUE.Name = "textBoxInputStartStep_KUE";
            this.textBoxInputStartStep_KUE.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputStartStep_KUE.TabIndex = 0;
            // 
            // buttonStartCode_KUE
            // 
            this.buttonStartCode_KUE.BackColor = System.Drawing.Color.Green;
            this.buttonStartCode_KUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartCode_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartCode_KUE.Location = new System.Drawing.Point(805, 24);
            this.buttonStartCode_KUE.Name = "buttonStartCode_KUE";
            this.buttonStartCode_KUE.Size = new System.Drawing.Size(132, 62);
            this.buttonStartCode_KUE.TabIndex = 6;
            this.buttonStartCode_KUE.Text = "Выполнить";
            this.buttonStartCode_KUE.UseVisualStyleBackColor = false;
            this.buttonStartCode_KUE.Click += new System.EventHandler(this.buttonStartCode_KUE_Click);
            // 
            // buttonSave_KUE
            // 
            this.buttonSave_KUE.BackColor = System.Drawing.Color.Blue;
            this.buttonSave_KUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_KUE.Location = new System.Drawing.Point(943, 23);
            this.buttonSave_KUE.Name = "buttonSave_KUE";
            this.buttonSave_KUE.Size = new System.Drawing.Size(132, 62);
            this.buttonSave_KUE.TabIndex = 7;
            this.buttonSave_KUE.Text = "Сохранить";
            this.buttonSave_KUE.UseVisualStyleBackColor = false;
            this.buttonSave_KUE.Click += new System.EventHandler(this.buttonSave_KUE_Click);
            // 
            // buttonSpravka
            // 
            this.buttonSpravka.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSpravka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpravka.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka.Location = new System.Drawing.Point(1081, 23);
            this.buttonSpravka.Name = "buttonSpravka";
            this.buttonSpravka.Size = new System.Drawing.Size(132, 62);
            this.buttonSpravka.TabIndex = 8;
            this.buttonSpravka.Text = "Справка";
            this.buttonSpravka.UseVisualStyleBackColor = false;
            this.buttonSpravka.Click += new System.EventHandler(this.buttonSpravka_Click_1);
            // 
            // groupBoxOutputData_KUE
            // 
            this.groupBoxOutputData_KUE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxOutputData_KUE.Controls.Add(this.textBoxResult);
            this.groupBoxOutputData_KUE.Controls.Add(this.labelResult);
            this.groupBoxOutputData_KUE.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutputData_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_KUE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_KUE.Name = "groupBoxOutputData_KUE";
            this.groupBoxOutputData_KUE.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxOutputData_KUE.Size = new System.Drawing.Size(347, 591);
            this.groupBoxOutputData_KUE.TabIndex = 9;
            this.groupBoxOutputData_KUE.TabStop = false;
            this.groupBoxOutputData_KUE.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(10, 25);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(331, 556);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(14, 29);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(68, 15);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Результат:";
            // 
            // chart_KUE
            // 
            this.chart_KUE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart_KUE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_KUE.Legends.Add(legend1);
            this.chart_KUE.Location = new System.Drawing.Point(0, 0);
            this.chart_KUE.Name = "chart_KUE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_KUE.Series.Add(series1);
            this.chart_KUE.Size = new System.Drawing.Size(881, 591);
            this.chart_KUE.TabIndex = 2;
            this.chart_KUE.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "TitleFunction";
            title1.Text = "График функции";
            this.chart_KUE.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.groupBoxTask_KUE);
            this.panel1.Controls.Add(this.groupBoxInputData_KUE);
            this.panel1.Controls.Add(this.buttonSpravka);
            this.panel1.Controls.Add(this.buttonStartCode_KUE);
            this.panel1.Controls.Add(this.buttonSave_KUE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 100);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.groupBoxOutputData_KUE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 591);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1234, 691);
            this.panel3.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(353, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 591);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.chart_KUE);
            this.groupBox1.Location = new System.Drawing.Point(353, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 591);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 691);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1250, 730);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 16 | Куприянов Е.А. ";
            this.groupBoxTask_KUE.ResumeLayout(false);
            this.groupBoxTask_KUE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInputData_KUE.ResumeLayout(false);
            this.groupBoxInputData_KUE.PerformLayout();
            this.groupBoxOutputData_KUE.ResumeLayout(false);
            this.groupBoxOutputData_KUE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_KUE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KUE;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.GroupBox groupBoxInputData_KUE;
        private System.Windows.Forms.Label labelInputStopStep_KUE;
        private System.Windows.Forms.Label labelInputStartStep_KUE;
        private System.Windows.Forms.TextBox textBoxInputStopStep_KUE;
        private System.Windows.Forms.TextBox textBoxInputStartStep_KUE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStartCode_KUE;
        private System.Windows.Forms.Button buttonSave_KUE;
        private System.Windows.Forms.Button buttonSpravka;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KUE;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KUE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

