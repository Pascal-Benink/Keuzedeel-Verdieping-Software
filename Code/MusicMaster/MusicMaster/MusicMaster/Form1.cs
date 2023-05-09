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
            player.settings.volume = Decimal.ToInt32(Volume.Value);  
            NowPlaying.Text = "Now Playing: Nothing";
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
            player.settings.volume = Decimal.ToInt32(Volume.Value);
        }

        private void Pause_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void Skip_Click(object sender, EventArgs e)
        {

        }

        private void Mute_Click(object sender, EventArgs e)
        {
            player.settings.volume = 0;
        }

        private void Unmute_Click(object sender, EventArgs e)
        {
            player.settings.volume = Decimal.ToInt32(Volume.Value);
        }

        private void NowPlaying_Click(object sender, EventArgs e)
        {

        }
    }
}