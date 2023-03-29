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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] kuku = new string[4];
                kuku[0] = " Пронин Евгений Павлович, 2 Курс, 2.2ИСиП-2, 3,4";
                kuku[1] = " Анохин Вячеслав Александрович, 2 Курс, 2.2ИСиП-2, 7, 5";
                kuku[2] = " Щербаков Никита Алексеевич, 2 Курс, 2.2ИСиП-2, 1, 3";
                kuku[3] = " Белкин Роман Сергеевич, 2 Курс, 2.2ИСиП-2, 12,5";
                dataGridView1.Rows.Add();
                dataGridView1.Columns.Add(" ", " ");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = kuku[i];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Границы закончены");
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 kuku = new Form1();
            kuku.Show();
            this.Hide();

        }
    }
}
