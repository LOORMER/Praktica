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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        public int count = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = DateTime.Now.ToShortDateString() + "," + DateTime.Now.ToLongDateString();
            Timer time = new Timer();
            time.Interval = 1000;
            time.Tick += new EventHandler(timer1_Tick);
            time.Enabled = true;
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            DateTime dt = DateTime.Now;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongDateString();
            this.textBox1.Text = (++count).ToString();
            if (count == 60 || count== 120|| count == 180)
            {
                MessageBox.Show("МИнута прошла");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
    }
}
