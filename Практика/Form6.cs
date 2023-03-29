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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= '0' )
            {
                MessageBox.Show("Нули нельзя");
            }
            else
            {
                double a = Convert.ToDouble(numericUpDown1.Value);
                double y = a * (a + 1) / 2;
                label1.Text = Convert.ToString(y);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 keke = new Form1();
            keke.Show();
            this.Hide();
        }
    }
}
