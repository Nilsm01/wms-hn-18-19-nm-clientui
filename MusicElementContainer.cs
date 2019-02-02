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
    public partial class MusicElementContainer : UserControl
    {
        public MusicElementContainer()
        {
            InitializeComponent();
        }

        public string SongName
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public void ChangePlayState(bool PlayState)
        {
            if (PlayState)
            {
                button1.Text = "⏸";
            }
            else
            {
                button1.Text = "►";
            }
        }

        private void MusicElementContainer_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "⏸")
            {
                button1.Text = "►";
                UIControls.Resources.Player.Pause();
            }
            else
            {
                button1.Text = "⏸";
                UIControls.Resources.Player.musicElement = this;
                if (UIControls.Resources.Player.CurrentlyPlaying != SongName)
                {
                    string FileName = Environment.CurrentDirectory + "\\Files\\" + SongName + ".mp3";
                    UIControls.Resources.Player.Play(FileName);
                }
                else
                    UIControls.Resources.Player.Play();
            }
        }
    }
}
