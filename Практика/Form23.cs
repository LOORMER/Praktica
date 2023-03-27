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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }
        public static string str;

        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text = File.ReadAllText(@"D:\Практика ПронинЩербаков\KU.txt");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;
            char str_char = 'a';
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str_char)
                {
                    str = str.Remove(i, 1);
                }
            }
            textBox1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sv = openFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(sv);
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }
        }
    }
}
