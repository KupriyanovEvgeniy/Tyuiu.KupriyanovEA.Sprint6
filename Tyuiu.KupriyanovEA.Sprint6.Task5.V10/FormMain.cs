using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KupriyanovEA.Sprint6.Task5.V10.Lib;

namespace Tyuiu.KupriyanovEA.Sprint6.Task5.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\evgeniy\source\repos\Tyuiu.KupriyanovEA.Sprint6\Tyuiu.KupriyanovEA.Sprint6.Task5.V10\bin\Debug\InPutFileTask5V10.txt";
        private void buttonStartCode_KUE_Click(object sender, EventArgs e)
        {
            dataGridViewOutputData.ColumnCount = 2;
            dataGridViewOutputData.Columns[0].Width = 20;
            dataGridViewOutputData.Columns[1].Width = 50;

            this.chart_Kue.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart_Kue.ChartAreas[0].AxisY.Title = "Ось Y";

            chart_Kue.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutputData.Rows.Add(i.ToString(), numsMass[i].ToString());
                chart_Kue.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonFIle_KUE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonSpravka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-2 Куприянов Евгений Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
