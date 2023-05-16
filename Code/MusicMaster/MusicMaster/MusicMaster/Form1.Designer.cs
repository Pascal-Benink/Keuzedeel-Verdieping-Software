namespace MusicMaster
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MusicFolder = new TextBox();
            MusicFolderConfirm = new Button();
            label2 = new Label();
            NowPlaying = new Label();
            PlayButton = new Button();
            Back = new Button();
            Skip = new Button();
            Pause = new Button();
            Stop = new Button();
            MuteIndicator = new Label();
            VolumeRange = new Label();
            Volume = new NumericUpDown();
            Mute = new Button();
            Unmute = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Volume).BeginInit();
            SuspendLayout();
            // 
            // MusicFolder
            // 
            MusicFolder.Location = new Point(153, 10);
            MusicFolder.Name = "MusicFolder";
            MusicFolder.Size = new Size(231, 31);
            MusicFolder.TabIndex = 0;
            MusicFolder.Text = "\r\n";
            MusicFolder.TextChanged += MusicFolder_TextChanged;
            // 
            // MusicFolderConfirm
            // 
            MusicFolderConfirm.Location = new Point(390, 10);
            MusicFolderConfirm.Name = "MusicFolderConfirm";
            MusicFolderConfirm.Size = new Size(133, 31);
            MusicFolderConfirm.TabIndex = 1;
            MusicFolderConfirm.Text = "Confirm";
            MusicFolderConfirm.UseVisualStyleBackColor = true;
            MusicFolderConfirm.Click += MusicFolderConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 13);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 3;
            label2.Text = "Uw Muziek Folder";
            // 
            // NowPlaying
            // 
            NowPlaying.AutoSize = true;
            NowPlaying.Location = new Point(3, 44);
            NowPlaying.Name = "NowPlaying";
            NowPlaying.Size = new Size(115, 25);
            NowPlaying.TabIndex = 4;
            NowPlaying.Text = "Now Playing:";
            NowPlaying.Click += NowPlaying_Click;
            // 
            // PlayButton
            // 
            PlayButton.Location = new Point(4, 126);
            PlayButton.Name = "PlayButton";
            PlayButton.RightToLeft = RightToLeft.No;
            PlayButton.Size = new Size(380, 49);
            PlayButton.TabIndex = 5;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // Back
            // 
            Back.Location = new Point(4, 79);
            Back.Name = "Back";
            Back.RightToLeft = RightToLeft.No;
            Back.Size = new Size(182, 41);
            Back.TabIndex = 6;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Skip
            // 
            Skip.Location = new Point(192, 79);
            Skip.Name = "Skip";
            Skip.RightToLeft = RightToLeft.No;
            Skip.Size = new Size(192, 41);
            Skip.TabIndex = 7;
            Skip.Text = "Skip";
            Skip.UseVisualStyleBackColor = true;
            Skip.Click += Skip_Click;
            // 
            // Pause
            // 
            Pause.Location = new Point(4, 181);
            Pause.Name = "Pause";
            Pause.RightToLeft = RightToLeft.No;
            Pause.Size = new Size(380, 49);
            Pause.TabIndex = 8;
            Pause.Text = "Pause";
            Pause.UseVisualStyleBackColor = true;
            Pause.Click += Pause_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(4, 236);
            Stop.Name = "Stop";
            Stop.RightToLeft = RightToLeft.No;
            Stop.Size = new Size(380, 49);
            Stop.TabIndex = 9;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // MuteIndicator
            // 
            MuteIndicator.AutoSize = true;
            MuteIndicator.Location = new Point(408, 71);
            MuteIndicator.Name = "MuteIndicator";
            MuteIndicator.Size = new Size(86, 25);
            MuteIndicator.TabIndex = 10;
            MuteIndicator.Text = "Unmuted";
            MuteIndicator.Click += MuteIndicator_Click;
            // 
            // VolumeRange
            // 
            VolumeRange.AutoSize = true;
            VolumeRange.Location = new Point(396, 100);
            VolumeRange.Name = "VolumeRange";
            VolumeRange.Size = new Size(124, 25);
            VolumeRange.TabIndex = 11;
            VolumeRange.Text = "Volume 0-100";
            // 
            // Volume
            // 
            Volume.Location = new Point(394, 136);
            Volume.Name = "Volume";
            Volume.Size = new Size(130, 31);
            Volume.TabIndex = 13;
            Volume.Value = new decimal(new int[] { 100, 0, 0, 0 });
            Volume.ValueChanged += Volume_ValueChanged;
            // 
            // Mute
            // 
            Mute.Location = new Point(393, 181);
            Mute.Name = "Mute";
            Mute.RightToLeft = RightToLeft.No;
            Mute.Size = new Size(130, 49);
            Mute.TabIndex = 14;
            Mute.Text = "Mute";
            Mute.UseVisualStyleBackColor = true;
            Mute.Click += Mute_Click;
            // 
            // Unmute
            // 
            Unmute.Location = new Point(394, 236);
            Unmute.Name = "Unmute";
            Unmute.RightToLeft = RightToLeft.No;
            Unmute.Size = new Size(130, 47);
            Unmute.TabIndex = 15;
            Unmute.Text = "Unmute";
            Unmute.UseVisualStyleBackColor = true;
            Unmute.Click += Unmute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 44);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 16;
            label1.Text = "Geen Muziek gevonden";
            label1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 294);
            Controls.Add(label1);
            Controls.Add(Unmute);
            Controls.Add(Mute);
            Controls.Add(Volume);
            Controls.Add(VolumeRange);
            Controls.Add(MuteIndicator);
            Controls.Add(Stop);
            Controls.Add(Pause);
            Controls.Add(Skip);
            Controls.Add(Back);
            Controls.Add(PlayButton);
            Controls.Add(NowPlaying);
            Controls.Add(label2);
            Controls.Add(MusicFolderConfirm);
            Controls.Add(MusicFolder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(557, 350);
            Name = "Form1";
            Text = "MusicMaster";
            ((System.ComponentModel.ISupportInitialize)Volume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MusicFolder;
        private Button MusicFolderConfirm;
        private Label label2;
        private Label NowPlaying;
        private Button PlayButton;
        private Button Back;
        private Button Skip;
        private Button Pause;
        private Button Stop;
        private Label MuteIndicator;
        private Label VolumeRange;
        private NumericUpDown Volume;
        private Button Mute;
        private Button Unmute;
        private Label label1;
    }
}