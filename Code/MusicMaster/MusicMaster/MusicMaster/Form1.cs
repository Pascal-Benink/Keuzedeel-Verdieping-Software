using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace MusicMaster
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        bool start = false;
        string[] musicFiles;
        int currentMusicIndex = 0;
        string musicFolderPath;
        public Form1()
        {
            InitializeComponent();
            /*            player.settings.volume = Convert.ToInt16(textBox1.Text);
                        label1.Text = "Now Playing: Nothing";*/
        }

        private void MusicFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusicFolderConfirm_Click(object sender, EventArgs e)
        {
            musicFolderPath = MusicFolder.Text;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

        }

        private void Volume_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}