using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayTwoSoundSimultaneously
{
    public partial class Form1 : Form
    {
        private System.Windows.Media.MediaPlayer p1 = new System.Windows.Media.MediaPlayer();
        private System.Media.SoundPlayer Player = new System.Media.SoundPlayer();

        private System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(System.Windows.Forms.Application.StartupPath).Parent.Parent;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string file = dir.FullName + "\\Sounds\\" + "background.wav";
            if (e.KeyChar == 'p')
            { 
                p1.Open(new System.Uri(file));
                p1.Play();
            }
            if (e.KeyChar == 's')
            {
                p1.Stop();
            }
        }

        private void btnWate_Click(object sender, EventArgs e)
        {
            string file = dir.FullName + "\\Sounds\\" + "Wate.wav";
            this.Player.SoundLocation = file;
            this.Player.Play();
        }
    }
}
