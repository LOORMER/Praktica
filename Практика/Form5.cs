﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            
            
            
        
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b = "";
            string c = "";
            string a = textBox1.Text;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] >= '0' && a[i] <= '9')
                {
                    b += a[i];
                }
                else
                {
                    c += a[i];
                }
                
            }
            MessageBox.Show( "Буквы в строке" + c);

        }
    }
}
