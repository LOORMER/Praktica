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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        public static int[,] a;
        public static int[,] b;
        public static int c = 0;
        public static int d = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            a = new int[4, 4];
            b = new int[4, 4];

            Random rand = new Random();
            dataGridView1.RowCount = a.GetLength(0);
            dataGridView2.RowCount = a.GetLength(0);
            dataGridView1.ColumnCount = b.GetLength(1);
            dataGridView2.ColumnCount = b.GetLength(1);

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(1, 40);
                    b[i, j] = rand.Next(1, 40);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                    dataGridView2.Rows[i].Cells[j].Value = b[i, j];

                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        c = c + (a[i, j]);
                    }
                }
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        d = d + (b[i, j]);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(maskedTextBox1.Text);
            double y = c * Math.Pow(x, 2) + d;
            listBox1.Items.Add(y.ToString());
        }
    }
}
