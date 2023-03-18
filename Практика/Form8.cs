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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[11];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(0, 50);
                if (a[i]==a[8])
                {
                    listBox1.Items.Add(a[0]);
                    listBox1.Items.Add(new string('-', 23));
                    listBox1.Items.Add(a[1] + " "+ a[2]);
                    listBox1.Items.Add(new string('-', 23));
                    listBox1.Items.Add(a[3]);
                    listBox1.Items.Add(new string('-', 23));
                    listBox1.Items.Add(a[4] + " " + a[5]);
                    listBox1.Items.Add(new string('-', 23));
                    listBox1.Items.Add(a[6] + " " + a[7] + " " + a[8]);
                    

                }
            }
        }
    }
}
