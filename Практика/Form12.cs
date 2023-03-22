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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(maskedTextBox1.Text);
            double y;
            double ctg = Math.Pow(1 / Math.Tan(x), 3);
            if (5 <= x && x < 10) 
            {
                y = 1 - Math.Sin(x);
                label2.Text = (y.ToString());
            }
            if (10 <= x && x < 15)
            {
                y = (1 + Math.Cos(x)) / 2;
                label2.Text = (y.ToString());
            }
            if (15 <= x && x < 20)
            {
                y = Math.Tan(x) / 3;
                label2.Text = (y.ToString());
            }
            if (20 <= x && x < 25) 

            {
                y = ctg;
                label2.Text = (y.ToString());
            }
        }
    }
}
