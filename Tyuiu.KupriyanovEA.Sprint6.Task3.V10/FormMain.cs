﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KupriyanovEA.Sprint6.Task3.V10.Lib;

namespace Tyuiu.KupriyanovEA.Sprint6.Task3.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -17, 6, -19, 6, -13 },
                                           { -19, 3, 12, -11, 19 },
                                           { -20, 11, 9, 19, -19 },
                                           { -20, 10, -9, 17, 9 },
                                           { -4, 9, -8, 13, -8 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewInputMatrix_KUE.ColumnCount = columns;
            dataGridViewInputMatrix_KUE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInputMatrix_KUE.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInputMatrix_KUE.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonSpravka_KUE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-2 Куприянов Евгений Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStartCode_KUE_Click(object sender, EventArgs e)
        {
            int[,] matrixres = ds.Calculate(matrix);

            int rows = matrixres.GetUpperBound(0) + 1;
            int columns = matrixres.Length / rows;

            dataGridViewOutputMatrix_KUE.ColumnCount = columns;
            dataGridViewOutputMatrix_KUE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutputMatrix_KUE.Columns[i].Width = 50;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutputMatrix_KUE.Rows[i].Cells[j].Value = Convert.ToString(matrixres[i, j]);
                }
            }
        }
    }
}
