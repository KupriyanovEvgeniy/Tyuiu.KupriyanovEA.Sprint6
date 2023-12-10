
namespace Tyuiu.KupriyanovEA.Sprint6.Task6.V19
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxUslovie = new System.Windows.Forms.GroupBox();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.textBoxInputData = new System.Windows.Forms.TextBox();
            this.textBoxOutPutData = new System.Windows.Forms.TextBox();
            this.buttonExploreData = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxUslovie.SuspendLayout();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxOutputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Controls.Add(this.buttonExploreData);
            this.panel1.Controls.Add(this.groupBoxUslovie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 176);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxInputData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 485);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxOutputData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(500, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 485);
            this.panel3.TabIndex = 0;
            // 
            // groupBoxUslovie
            // 
            this.groupBoxUslovie.Controls.Add(this.textBoxUslovie);
            this.groupBoxUslovie.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxUslovie.Location = new System.Drawing.Point(12, 87);
            this.groupBoxUslovie.Name = "groupBoxUslovie";
            this.groupBoxUslovie.Size = new System.Drawing.Size(960, 83);
            this.groupBoxUslovie.TabIndex = 0;
            this.groupBoxUslovie.TabStop = false;
            this.groupBoxUslovie.Text = "Условие";
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.textBoxInputData);
            this.groupBoxInputData.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInputData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.groupBoxInputData.Size = new System.Drawing.Size(494, 485);
            this.groupBoxInputData.TabIndex = 0;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод";
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.textBoxOutPutData);
            this.groupBoxOutputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.groupBoxOutputData.Size = new System.Drawing.Size(484, 485);
            this.groupBoxOutputData.TabIndex = 0;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Вывод";
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Location = new System.Drawing.Point(7, 22);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(947, 55);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = resources.GetString("textBoxUslovie.Text");
            // 
            // textBoxInputData
            // 
            this.textBoxInputData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputData.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxInputData.Location = new System.Drawing.Point(10, 35);
            this.textBoxInputData.Multiline = true;
            this.textBoxInputData.Name = "textBoxInputData";
            this.textBoxInputData.Size = new System.Drawing.Size(471, 440);
            this.textBoxInputData.TabIndex = 0;
            this.textBoxInputData.TabStop = false;
            // 
            // textBoxOutPutData
            // 
            this.textBoxOutPutData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutPutData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPutData.Location = new System.Drawing.Point(10, 35);
            this.textBoxOutPutData.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxOutPutData.Multiline = true;
            this.textBoxOutPutData.Name = "textBoxOutPutData";
            this.textBoxOutPutData.Size = new System.Drawing.Size(464, 440);
            this.textBoxOutPutData.TabIndex = 0;
            this.textBoxOutPutData.TabStop = false;
            // 
            // buttonExploreData
            // 
            this.buttonExploreData.Image = ((System.Drawing.Image)(resources.GetObject("buttonExploreData.Image")));
            this.buttonExploreData.Location = new System.Drawing.Point(10, 13);
            this.buttonExploreData.Name = "buttonExploreData";
            this.buttonExploreData.Size = new System.Drawing.Size(87, 68);
            this.buttonExploreData.TabIndex = 1;
            this.buttonExploreData.TabStop = false;
            this.toolTip.SetToolTip(this.buttonExploreData, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonExploreData.UseVisualStyleBackColor = true;
            this.buttonExploreData.Click += new System.EventHandler(this.buttonExploreData_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.Location = new System.Drawing.Point(117, 13);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(87, 68);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.TabStop = false;
            this.toolTip.SetToolTip(this.buttonDone, "Производит поиск в фале вхождений сиволов \"l\"");
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.Location = new System.Drawing.Point(885, 13);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(87, 68);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.TabStop = false;
            this.toolTip.SetToolTip(this.buttonHelp, "Сведения о программе");
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "InPutFileTask6V19.txt";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 19 | Куприянов Е.А.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxUslovie.ResumeLayout(false);
            this.groupBoxUslovie.PerformLayout();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxOutputData.ResumeLayout(false);
            this.groupBoxOutputData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxUslovie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.TextBox textBoxInputData;
        private System.Windows.Forms.TextBox textBoxOutPutData;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonExploreData;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

