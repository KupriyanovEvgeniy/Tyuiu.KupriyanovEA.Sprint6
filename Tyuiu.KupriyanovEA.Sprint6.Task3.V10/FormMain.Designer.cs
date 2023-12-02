
namespace Tyuiu.KupriyanovEA.Sprint6.Task3.V10
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
            this.groupBoxTask_KUE = new System.Windows.Forms.GroupBox();
            this.dataGridViewInputMatrix_KUE = new System.Windows.Forms.DataGridView();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_KUE = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOutputMatrix_KUE = new System.Windows.Forms.DataGridView();
            this.buttonStartCode_KUE = new System.Windows.Forms.Button();
            this.buttonSpravka_KUE = new System.Windows.Forms.Button();
            this.groupBoxTask_KUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix_KUE)).BeginInit();
            this.groupBoxOutputData_KUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputMatrix_KUE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KUE
            // 
            this.groupBoxTask_KUE.Controls.Add(this.dataGridViewInputMatrix_KUE);
            this.groupBoxTask_KUE.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_KUE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KUE.Name = "groupBoxTask_KUE";
            this.groupBoxTask_KUE.Size = new System.Drawing.Size(449, 391);
            this.groupBoxTask_KUE.TabIndex = 2;
            this.groupBoxTask_KUE.TabStop = false;
            this.groupBoxTask_KUE.Text = "Условие";
            // 
            // dataGridViewInputMatrix_KUE
            // 
            this.dataGridViewInputMatrix_KUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputMatrix_KUE.ColumnHeadersVisible = false;
            this.dataGridViewInputMatrix_KUE.Location = new System.Drawing.Point(6, 57);
            this.dataGridViewInputMatrix_KUE.Name = "dataGridViewInputMatrix_KUE";
            this.dataGridViewInputMatrix_KUE.ReadOnly = true;
            this.dataGridViewInputMatrix_KUE.RowHeadersVisible = false;
            this.dataGridViewInputMatrix_KUE.Size = new System.Drawing.Size(254, 209);
            this.dataGridViewInputMatrix_KUE.TabIndex = 1;
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(437, 63);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.";
            // 
            // groupBoxOutputData_KUE
            // 
            this.groupBoxOutputData_KUE.Controls.Add(this.label1);
            this.groupBoxOutputData_KUE.Controls.Add(this.dataGridViewOutputMatrix_KUE);
            this.groupBoxOutputData_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_KUE.Location = new System.Drawing.Point(467, 13);
            this.groupBoxOutputData_KUE.Name = "groupBoxOutputData_KUE";
            this.groupBoxOutputData_KUE.Size = new System.Drawing.Size(480, 390);
            this.groupBoxOutputData_KUE.TabIndex = 7;
            this.groupBoxOutputData_KUE.TabStop = false;
            this.groupBoxOutputData_KUE.Text = "Вывод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат:";
            // 
            // dataGridViewOutputMatrix_KUE
            // 
            this.dataGridViewOutputMatrix_KUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputMatrix_KUE.ColumnHeadersVisible = false;
            this.dataGridViewOutputMatrix_KUE.Location = new System.Drawing.Point(6, 56);
            this.dataGridViewOutputMatrix_KUE.Name = "dataGridViewOutputMatrix_KUE";
            this.dataGridViewOutputMatrix_KUE.ReadOnly = true;
            this.dataGridViewOutputMatrix_KUE.RowHeadersVisible = false;
            this.dataGridViewOutputMatrix_KUE.Size = new System.Drawing.Size(254, 209);
            this.dataGridViewOutputMatrix_KUE.TabIndex = 1;
            // 
            // buttonStartCode_KUE
            // 
            this.buttonStartCode_KUE.BackColor = System.Drawing.Color.Green;
            this.buttonStartCode_KUE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStartCode_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartCode_KUE.Location = new System.Drawing.Point(803, 409);
            this.buttonStartCode_KUE.Name = "buttonStartCode_KUE";
            this.buttonStartCode_KUE.Size = new System.Drawing.Size(101, 38);
            this.buttonStartCode_KUE.TabIndex = 8;
            this.buttonStartCode_KUE.Text = "Выполнить";
            this.buttonStartCode_KUE.UseVisualStyleBackColor = false;
            this.buttonStartCode_KUE.Click += new System.EventHandler(this.buttonStartCode_KUE_Click);
            // 
            // buttonSpravka_KUE
            // 
            this.buttonSpravka_KUE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSpravka_KUE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSpravka_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka_KUE.Location = new System.Drawing.Point(760, 409);
            this.buttonSpravka_KUE.Name = "buttonSpravka_KUE";
            this.buttonSpravka_KUE.Size = new System.Drawing.Size(37, 38);
            this.buttonSpravka_KUE.TabIndex = 9;
            this.buttonSpravka_KUE.Text = "?";
            this.buttonSpravka_KUE.UseVisualStyleBackColor = false;
            this.buttonSpravka_KUE.Click += new System.EventHandler(this.buttonSpravka_KUE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.buttonSpravka_KUE);
            this.Controls.Add(this.buttonStartCode_KUE);
            this.Controls.Add(this.groupBoxOutputData_KUE);
            this.Controls.Add(this.groupBoxTask_KUE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 10 | Куприянов Е.А. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KUE.ResumeLayout(false);
            this.groupBoxTask_KUE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix_KUE)).EndInit();
            this.groupBoxOutputData_KUE.ResumeLayout(false);
            this.groupBoxOutputData_KUE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputMatrix_KUE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KUE;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.DataGridView dataGridViewInputMatrix_KUE;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KUE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOutputMatrix_KUE;
        private System.Windows.Forms.Button buttonStartCode_KUE;
        private System.Windows.Forms.Button buttonSpravka_KUE;
    }
}

