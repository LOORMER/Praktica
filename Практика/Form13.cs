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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        public static int[,] a ;
        public static int[,]  b ;
        public static int c = 0;
        public static int bruh = 0;
        public static int s = 0;
        public static int max = 0;





        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
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

                    if(a[i,j] > c)
                    {
                        c = a[i, j];
                    }

                    if (b[i, j] > bruh)
                    {
                        bruh = b[i, j];
                    }
                 
                    
                        
                }
            }
            if (c > bruh)
            {
                max = c;
                s = -1;
            }
            if (bruh == c)
            {
                s = 0;
            }
            if (bruh > c)
            {
                s = 1;
                max = bruh;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(max.ToString());
        }
    }
}
