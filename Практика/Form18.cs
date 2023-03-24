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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        Graphics g;
        public int i = 0;
        bool w = true;


        int x = Form.ActiveForm.Size.Width;
        int y = Form.ActiveForm.Size.Height;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10;
            x = Form.ActiveForm.Size.Width - 10;
            y = Form.ActiveForm.Size.Height - 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (w == true)
            {
                g.Clear(Color.White);
                g.DrawEllipse(Pens.Black, x--, y--, 10, 10);
            }
        }
    }
}
