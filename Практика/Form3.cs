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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y;
            double x = int.Parse(maskedTextBox1.Text);
            if(x >= 0)
            {
                y =(double) Math.Exp(x);
                y = Math.Round(y, 2);
                label1.Text = Convert.ToString(y);
            }
            else if(x < 0)
            {
                y = (double) Math.Cos(x);
                y = Math.Round(y, 2);
                label1.Text = Convert.ToString(y);
            }
            
        }

        
    }
}
