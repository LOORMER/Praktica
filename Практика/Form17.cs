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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        Image k1 = Image.FromFile(@"C:\Users\k257\Desktop\stay.png");
        Image k2 = Image.FromFile(@"C:\Users\k257\Desktop\dance.png");
        int i = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "dance";

            }
            else
            {
                timer1.Start();
                button1.Text = "stop";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(i % 3 == 0)
            {
                pictureBox1.Image = k1;
            }
           else if((i% 3 ==1))
            {
                pictureBox1.Image = k2;
            }
            i++;



            
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            
            progressBar1.Visible = false;
        }

       

        

       
    }
}
