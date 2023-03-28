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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }
        public ListBox listbox;
        public bool a;
        private void button1_Click(object sender, EventArgs e)
        {
            listbox.Items.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
            

        {
            try
            {


                a = true;
                if (listbox != null)
                {
                    if (a)
                    {
                        this.listbox.Items.RemoveAt(int.Parse(this.textBox1.Text) -1 );
                    }
                }
            }
            catch
            {
              MessageBox.Show("нельзя");
            }

        }
    }
}
