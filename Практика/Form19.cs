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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\ Windows\Media\Alarm10.wav";
            axWindowsMediaPlayer1.openPlayer( @"C:\ Windows\Media\Alarm10.wav");
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }
    }
}
