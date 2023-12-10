
namespace Tyuiu.KupriyanovEA.Sprint6.Task7.V4
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
            this.buttonExploreData = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxUslovie = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBoxUslovie.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxUslovie);
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Controls.Add(this.buttonExploreData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 163);
            this.panel1.TabIndex = 0;
            // 
            // buttonExploreData
            // 
            this.buttonExploreData.Image = ((System.Drawing.Image)(resources.GetObject("buttonExploreData.Image")));
            this.buttonExploreData.Location = new System.Drawing.Point(3, 3);
            this.buttonExploreData.Name = "buttonExploreData";
            this.buttonExploreData.Size = new System.Drawing.Size(87, 68);
            this.buttonExploreData.TabIndex = 2;
            this.buttonExploreData.TabStop = false;
            this.buttonExploreData.UseVisualStyleBackColor = true;
            this.buttonExploreData.Click += new System.EventHandler(this.buttonExploreData_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.Location = new System.Drawing.Point(96, 3);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(87, 68);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.TabStop = false;
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.Location = new System.Drawing.Point(894, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(87, 68);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.TabStop = false;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(189, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 68);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.TabStop = false;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxUslovie
            // 
            this.groupBoxUslovie.Controls.Add(this.textBoxUslovie);
            this.groupBoxUslovie.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxUslovie.Location = new System.Drawing.Point(12, 77);
            this.groupBoxUslovie.Name = "groupBoxUslovie";
            this.groupBoxUslovie.Size = new System.Drawing.Size(960, 83);
            this.groupBoxUslovie.TabIndex = 5;
            this.groupBoxUslovie.TabStop = false;
            this.groupBoxUslovie.Text = "Условие";
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
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 398);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxOutput);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(501, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 398);
            this.panel3.TabIndex = 2;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.dataGridViewInput);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxInput.Size = new System.Drawing.Size(488, 398);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridViewOutput);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOutput.Location = new System.Drawing.Point(3, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(1, 10, 10, 10);
            this.groupBoxOutput.Size = new System.Drawing.Size(480, 398);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод";
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.ColumnHeadersVisible = false;
            this.dataGridViewInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewInput.Location = new System.Drawing.Point(10, 23);
            this.dataGridViewInput.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.RowHeadersVisible = false;
            this.dataGridViewInput.Size = new System.Drawing.Size(474, 365);
            this.dataGridViewInput.TabIndex = 0;
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.ColumnHeadersVisible = false;
            this.dataGridViewOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewOutput.Location = new System.Drawing.Point(0, 23);
            this.dataGridViewOutput.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.RowHeadersVisible = false;
            this.dataGridViewOutput.Size = new System.Drawing.Size(470, 365);
            this.dataGridViewOutput.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Таск 6 | Вариант 4 | Куприянов Е.А.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxUslovie.ResumeLayout(false);
            this.groupBoxUslovie.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExploreData;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxUslovie;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
    }
}

