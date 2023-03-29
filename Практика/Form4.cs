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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                int y = int.Parse(maskedTextBox2.Text);
                int x = int.Parse(maskedTextBox1.Text);
                if (x == 0 && y == 0)
                {
                    MessageBox.Show("Нули нельзя");
                    return;
                }




                if (x < y)
                {
                    if (x < 0)
                    {
                        maskedTextBox1.Text = "0";

                    }
                    else
                    {
                        maskedTextBox1.Text = "1";
                    }
                }
                else
                {
                    if (y < 0)
                    {
                        maskedTextBox2.Text = "0";

                    }
                    else
                    {
                        maskedTextBox2.Text = "1";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введи значения ");
            }
        
             




        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 kuku = new Form1();
            kuku.Show();
            this.Hide();
        }
    }
}
