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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g = 0;
            string[] a = new string[4];
            char OC = '4';
            a[0] = "Пронин Евгений Павлович, Класс: 9В, Оценка: 3";
            a[1] = "Анохин ВячеславАлександровч, Класс: 9В, Оценка: 5";
            a[2] = "Щербавок Никита Алексеевич, Класс: 9Б, Оценкка: 2";
            a[3] = "Белкин Роман Сергеевич, Класс: 9А, Оценка: 4";

            listBox1.Items.Add(a[0] +" \n " + a[1] + "\n "  + a[2] + " \n" + a[3]);


              

        } 
    }
}
