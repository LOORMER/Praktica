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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[20];
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                a[i] = rand.Next(0, 50);
                listBox2.Items.Add(a[i]);
                listBox1.Items.Add(a[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> li = new List<int>();
            foreach (var s in listBox1.Items)
            {
                li.Add(Convert.ToInt32(s));
            }
            List<int> li2 = li;
            bool a = true;
            int l = 0;
            int x = 200;
             while(x != 0)
            {
                x --;
                int temp = 0;
                a = true;
                li2 = li;
                if (l == 0)
                {
                    l++;
                
                }
                else
                {
                    l = 0;
                }
                for (int i = l; i < li.Count -1 -l; i+= 2)
                {
                    if (li[i] < li[i + 1])
                    {
                        temp = li[i];
                        li[i] = li[i + 1];
                        li[i + 1] = temp;
                    }
                }
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i] != li2[i])
                    {
                        a = false;
                    }
                }

            }
            listBox1.Items.Clear();
            foreach(var item in li)
            {
                listBox1.Items.Add(item);
            }

            
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 19)
            {
                listBox1.SelectedIndex += 1;
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show("Слишком высоко");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex -= 1;
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show("Слишком низко");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 19)
            {
                listBox1.SelectedIndex += 10;
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show(" ХВАТИТ!");
            }
        }

       
    }
}
