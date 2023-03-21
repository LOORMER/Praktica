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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void математическиеИФизическиеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }

        private void ветвленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Hide();
        }

        private void ветвления2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }

        private void множестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
            this.Hide();
        }

        private void dowhilewhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.Show();
            this.Hide();
        }

        private void тематикаСписковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
            this.Hide();
        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.Show();
            this.Hide();


        }

        private void массивыToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
        }

        private void массивыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.Show();
            this.Hide();
        }

        private void строкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 fr10 = new Form10();
            fr10.Show();
            this.Hide();
        }

        private void сортировкаМассиваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr11 = new Form11();
            fr11.Show();
            this.Hide();
        }

        private void программыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr12 = new Form12();
            fr12.Show();
            this.Hide();
        }
    }
}
