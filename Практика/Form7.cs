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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Улица Юговосточная дом 17;  " +
                " Аэродромная 5Б; " +
                "Южный микрорайон ОБЩАГА; " +
                "Ул Ленинская дом120; " +
                " Советская 56;"); 
        }
    }
}
