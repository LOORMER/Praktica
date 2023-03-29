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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
              



                try
                {


                    double H = Convert.ToDouble(maskedTextBox1.Text);
                    double min = -Convert.ToDouble(maskedTextBox3.Text);
                    double max = Convert.ToDouble(maskedTextBox2.Text);
                    int co = Convert.ToInt32(Math.Ceiling((max - min) / H) + 1);
                    double[] x = new double[co];
                    double[] y1 = new double[co];
                    double[] y2 = new double[co];

                    for (int i = 0; i < co; i++)
                    {
                        x[i] = min + H * i;
                        y1[i] = Math.Sin(x[i]);
                        y2[i] = Math.Pow(x[i], 2);
                    }
                    chart1.ChartAreas[0].AxisX.Minimum = min;
                    chart1.ChartAreas[0].AxisX.Maximum = max;
                    chart1.ChartAreas[0].AxisX.MajorGrid.Interval = H;
                    chart1.Series[0].Points.DataBindXY(x, y1);
                    chart1.Series[0].Points.DataBindXY(x, y2);
                }
                catch
                {
                   MessageBox.Show("Нельзя");
                }
            }
            





        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button1.Enabled = false;
                maskedTextBox1.Enabled = false;
                maskedTextBox2.Enabled = false;

                maskedTextBox3.Enabled = false;
                try
                {


                    double H = Convert.ToDouble(maskedTextBox6.Text);
                    double min = -Convert.ToDouble(maskedTextBox4.Text);
                    double max = Convert.ToDouble(maskedTextBox5.Text);
                    int co = Convert.ToInt32(Math.Ceiling((max - min) / H) + 1);
                    double[] x = new double[co];
                    double[] y1 = new double[co];
                    double[] y2 = new double[co];

                    for (int i = 0; i < co; i++)
                    {
                        x[i] = min + H * i;
                        y1[i] = Math.Sin(x[i]);
                        y2[i] = Math.Pow(x[i], 2);
                    }
                    chart1.ChartAreas[0].AxisX.Minimum = min;
                    chart1.ChartAreas[0].AxisX.Maximum = max;
                    chart1.ChartAreas[0].AxisX.MajorGrid.Interval = H;
                    chart1.Series[0].Points.DataBindXY(x, y1);
                    chart1.Series[0].Points.DataBindXY(x, y2);
                }
                catch
                {
                    MessageBox.Show("Нельзя");
                }
            }
        }

        private void Form15_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 kuku = new Form1();
            kuku.Show();
            this.Hide();
        }
    }
}
