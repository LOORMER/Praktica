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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lines = File.ReadLines(@"D:\Практика ПронинЩербаков\RE.txt");
            var Max = " ";
            foreach (string line in lines)
            {

                if (Max.Length < line.Length)
                {
                    Max = line;
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pat = openFileDialog1.FileName;
                using (StreamReader read = File.OpenText(pat))
                {
                    textBox1.Clear();
                    textBox1.Text = Max;

                }
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 kuku = new Form1();
            kuku.Show();
            this.Hide();
        }
    }
}
