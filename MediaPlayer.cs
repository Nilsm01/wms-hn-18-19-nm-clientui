using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class MediaPlayer : UserControl
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private WMPLib.WindowsMediaPlayer Player;
        public string CurrentlyPlaying = string.Empty;
        private MusicElementContainer elementContainer;
        public MusicElementContainer musicElement
        {
            get
            {
                return elementContainer;
            }
            set
            {
                if (elementContainer != null)
                    elementContainer.ChangePlayState(false);
                elementContainer = value;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                Pause();
            else if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
                Play();
            else
                MessageBox.Show("Unbekannte PlayState!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Player.settings.volume = e.NewValue;
        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.settings.volume = metroTrackBar1.Value;
        }

        public void Play(string FileName)
        {
            if (Player.URL == FileName)
            {
                if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    Pause();
                else
                    Play();
            }
            else
            {
                string path = System.IO.Path.GetFileNameWithoutExtension(FileName);
                if (UIControls.Resources.MyMusicElements == null)
                {
                    UIControls.Handler.SetMyMusic();
                }
                UIControls.Resources.MyMusicElements.Where(i => i.SongName == path).FirstOrDefault().ChangePlayState(true);
                Player.URL = FileName;
                this.label2.Text = path;
                Player.controls.play();
                ClientLib.Resources.Services.DataPackage.SendSongClickMessage(path);
                ClientLib.UserProfile.Administrator.AddItemsToList(path);
                CurrentlyPlaying = path;
            }
        }

        public void Play()
        {
            Player.controls.play();
            if(elementContainer != null)
                elementContainer.ChangePlayState(true);
        }

        public void Pause()
        {
            Player.controls.pause();
            if (elementContainer != null)
                elementContainer.ChangePlayState(false);
        }

        public void Stop()
        {
            Player.controls.stop();
        }
    }
}
