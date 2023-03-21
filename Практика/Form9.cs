using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public static int[,] a; 

        private void button2_Click(object sender, EventArgs e)
        {

              
            a = new int[3, 3];
            Random rand = new Random();
            dataGridView1.RowCount = a.GetLength(0);
            dataGridView1.ColumnCount = a.GetLength(1);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(0, 50);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Min;
            int Max;
            int iMax;
            int jMax;
            int iMin;
            int jMin;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Min = a[i, 0];
                Max = a[i, 0];
                jMin = 0;
                jMax = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] <= Min)
                    {
                        Min = a[i, j];
                        jMin = j;
                    }
                    if (a[i, j] >= Max)
                    {
                        Max = a[i, j];
                        jMax = j;
                    }
                }
                a[i, jMin] = Max;
                a[i, jMax] = Min;
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                }
            }
        }
    }
}
