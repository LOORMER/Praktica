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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }
        int i = 0;

        private void Form26_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i == 1000)
            {
                timer1.Stop();
                Form1 ne = new Form1();
                ne.Show();
                this.Hide();

            }
            else
            {
                i += timer1.Interval;
                progressBar1.PerformStep();
            }
        }
    }
}
