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
        // public static double x = 0;
        public static int y;
        public static double[] x;
        public static double[] y1 = new double[10];
  

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
            try
            {



                for (int i = 0; i < x.Length; i++)
                {
                    y1[i] = c * Math.Pow(x[i], 2) + d;
                    textBox2.Text += y1[i].ToString() + " ";
                }
            }
            catch
            {
                MessageBox.Show(" сначала заполни массив и заполни X");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             x = new double[10];
            x[0] = 0.1;
            x[1] = 0.2;
            x[2] = 0.3;
            x[3] = 0.4;
            x[4] = 0.5;
            x[5] = 0.6;
            x[6] = 0.7;
            x[7] = 0.8;
            x[8] = 0.9;
            x[9] = 1;
            this.textBox1.Text = (x[0]).ToString() + " " + (x[1]).ToString() + " " + (x[2]).ToString() + " " + (x[3]).ToString() + " " + (x[4]).ToString() + " " + (x[5]).ToString() + " " + (x[6]).ToString() + " " + (x[7]).ToString() + " " + (x[8]).ToString() + " " + (x[9]).ToString();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 kuku = new Form1();
            kuku.Show();
            this.Hide();
        }
    }
}
