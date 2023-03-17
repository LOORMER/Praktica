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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > 0 && numericUpDown2.Value > 0 && numericUpDown3.Value > 0)
            {
                double a = Convert.ToDouble(numericUpDown1.Value);
                double b = Convert.ToDouble(numericUpDown3.Value);

                double c = Convert.ToDouble(numericUpDown2.Value);
                double p = (a + b + c) / 2;
                double y = (double) Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                y = Math.Round(y, 2);
                label1.Text = Convert.ToString(y);
                
            }
            else
            {
                MessageBox.Show("Использование нулевых значений запрещено!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();

        }
    }
}
