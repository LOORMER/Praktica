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

        private void подпрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 fr13 = new Form13();
            fr13.Show();
            this.Hide();

        }

        private void подпрограммы1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 fr14 = new Form14();
            fr14.Show();
            this.Hide();
        }

        private void графикФункцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 fr15 = new Form15();
            fr15.Show();
            this.Hide();
        }

        private void графикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 fr16 = new Form16();
            fr16.Show();
            this.Hide();
        }

        private void анимацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 fr17 = new Form17();
            fr17.Show();
            this.Hide();
        }

        private void графикаИДвиженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 fr18 = new Form18();
            fr18.Show();
            this.Hide();
        }

        private void mediaPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form19 fr19 = new Form19();
            fr19.Show();
            this.Hide();
        }

        private void файлыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 fr20 = new Form20();
            fr20.Show();
            this.Hide();
        }

        private void текстовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 fr21 = new Form21();
            fr21.Show();
            this.Hide();
        }

        private void записиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22 fr22 = new Form22();
            fr22.Show();
            this.Hide();
        }
    }
}
