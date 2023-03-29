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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public static string str;

        private void button1_Click(object sender, EventArgs e)
        {
           
            

           
            str = textBox1.Text;
            char str_char = 'а';
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == str_char)
                {
                    str = str.Remove(i, 1);
                }
            }
            textBox1.Text = str;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 kuku = new Form1();
            kuku.Show();
            this.Hide();
        }
    }
}
