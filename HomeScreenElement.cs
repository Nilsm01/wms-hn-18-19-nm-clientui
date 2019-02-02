using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace ClientUI
{
    public partial class HomeScreenElement : UserControl
    {
        public HomeScreenElement()
        {
            InitializeComponent();
        }

        public string FileName { get; set; }
        public Label SongName { get; set; }
        public PictureBox image { get; set; }
        public int identifier { get; set; }
        private bool SongExists { get; set; }
        public string ButtonText
        {
            get
            {
                return metroButton1.Text;
            }
            set
            {
                metroButton1.Invoke(new MethodInvoker(delegate () { metroButton1.Text = value; }));
                if (metroButton1.Text == "Play")
                    SongExists = true;
            }
        }

        private void HomeScreenElement_Load(object sender, EventArgs e)
        {
            image = pictureBox1;
            SongName = label1;
            metroButton1.Text = "Download";
        }

        public void DownloadPicture(string URL, int identifier)
        {
            this.identifier = identifier;
            WebClient wc = new WebClient();
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            Uri URI = new Uri(URL);
            wc.DownloadFileAsync(URI, Environment.CurrentDirectory + "\\Data\\" + "pic" + identifier + ".dat");
            if (File.Exists(Environment.CurrentDirectory + "\\Files\\" + FileName + ".mp3"))
            {
                SongExists = true;
                metroButton1.Text = "Play";
            }
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                image.Image = Image.FromFile(Environment.CurrentDirectory + "\\Data\\" + "pic" + identifier + ".dat");
            }
            catch
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!SongExists)
                ClientLib.Resources.Services.DataPackage.SendSongRequest(FileName);
            else
                UIControls.Resources.Player.Play(Environment.CurrentDirectory + "\\Files\\" + FileName + ".mp3");
        }
    }
}
