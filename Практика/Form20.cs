using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Практика
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
       
        

        private void Form20_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            button4.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pat = openFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(pat);
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }
            button2.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pat = openFileDialog1.FileName;
                using (StreamReader read = File.OpenText(pat))
                {
                    textBox1.Clear();
                    textBox1.Text = read.ReadToEnd();

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss dddd");
            
            toolStripStatusLabel2.Text = openFileDialog1.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    if(listBox1.Items[i].ToString() == listBox1.Items[j].ToString())
                    {
                        
                    }

                }
            }
        }
    }
}
