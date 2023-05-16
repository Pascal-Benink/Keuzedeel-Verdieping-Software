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
        string musicName;
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

            if (start == true)
            {
                player.controls.play();
                NowPlaying.Text = "Now Playing: " + musicName;
            }
            else
            {
                if (musicFolderPath != null)
                {
                    musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3", SearchOption.AllDirectories);
                    if (musicFiles.Length > 0)
                    {
                        IWMPPlaylist playlist = player.playlistCollection.newPlaylist("Music");

                        foreach (string musicFile in musicFiles)
                        {
                            IWMPMedia media = player.newMedia(musicFile);
                            playlist.appendItem(media);
                        }

                        player.currentPlaylist = playlist;
                        player.controls.play();
                        player.PlayStateChange += Player_PlayStateChange;
                        start = true;
                        musicName = Path.GetFileNameWithoutExtension(player.controls.currentItem.sourceURL);
                        NowPlaying.Text = "Now Playing: " + musicName;
                    }
                    else
                    {
                        MusicFolder.Text = "Geen Muziek gevonden";
                    }
                }
                else
                {
                    MusicFolder.Text = "Geen MuziekFolder gevonden";
                }
            }
        }

        private void Volume_ValueChanged(object sender, EventArgs e)
        {
            player.settings.volume = Decimal.ToInt32(Volume.Value);
            MuteIndicator.Text = "Unmuted";
            if (Decimal.ToInt32(Volume.Value) == 0)
            {
                player.settings.volume = Decimal.ToInt32(Volume.Value);
                MuteIndicator.Text = "Muted";
            }
        }
        private void Volume_TextChanged(object sender, EventArgs e)
        {
            player.settings.volume = Decimal.ToInt32(Volume.Value);
            MuteIndicator.Text = "Unmuted";
            if (Decimal.ToInt32(Volume.Value) == 0)
            {
                player.settings.volume = Decimal.ToInt32(Volume.Value);
                MuteIndicator.Text = "Muted";
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            NowPlaying.Text = "Now Paused: " + musicName;
            player.controls.pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            NowPlaying.Text = "Now Playing: Nothing";
            player.controls.stop();
            start = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (player.currentPlaylist != null)
            {
                // Check if current track is the first track in the playlist
                if (player.controls.currentItem == player.currentPlaylist.Item[0])
                {
                    // Loop back to the last track
                    player.controls.currentItem = player.currentPlaylist.Item[player.currentPlaylist.count - 1];
                }
                else
                {
                    // Go to the previous track
                    player.controls.previous();
                }

                // Update label with current track information
                musicName = Path.GetFileNameWithoutExtension(player.controls.currentItem.sourceURL);
                NowPlaying.Text = "Now Playing: " + musicName;
            }
            }

            private void Skip_Click(object sender, EventArgs e)
        {
            if (player.currentPlaylist != null)
            {
                // Check if current track is the last track in the playlist
                if (player.controls.currentItem == player.currentPlaylist.Item[player.currentPlaylist.count - 1])
                {
                    // Loop back to the first track
                    player.controls.currentItem = player.currentPlaylist.Item[0];
                }
                else
                {
                    // Go to the next track
                    player.controls.next();
                }

                // Update label with current track information
                musicName = Path.GetFileNameWithoutExtension(player.controls.currentItem.sourceURL);
                NowPlaying.Text = "Now Playing: " + musicName;
            }
        }

        private void Mute_Click(object sender, EventArgs e)
        {
            player.settings.volume = 0;
            MuteIndicator.Text = "Muted";

        }

        private void Unmute_Click(object sender, EventArgs e)
        {
            player.settings.volume = Decimal.ToInt32(Volume.Value);
            MuteIndicator.Text = "Unmuted";
        }

        private void NowPlaying_Click(object sender, EventArgs e)
        {

        }

        private void MuteIndicator_Click(object sender, EventArgs e)
        {

        }
        private void Player_PlayStateChange(int NewState)
        {
            // Check if the new state is "playing"
            if ((WMPPlayState)NewState == WMPPlayState.wmppsPlaying)
            {
                // Update the NowPlaying label with the name of the current music file
                musicName = Path.GetFileNameWithoutExtension(player.controls.currentItem.sourceURL);
                NowPlaying.Text = "Now Playing: " + musicName;
            }
        }
    }
}