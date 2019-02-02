using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SplashScreen splashScreen;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_Load(object sender, EventArgs e)
        {
            splashScreen = new SplashScreen();
            splashScreen.Location = new Point(0, 0);
            this.Controls.Add(splashScreen);
            splashScreen.BringToFront();
            UIControls.Handler.Initialize(this, button1, button2, button3, button4, tabControl1, tabPage1, tabPage2, tabPage3, tabPage4, panel2, label1, listBox1, homeScreenElement1, homeScreenElement2, homeScreenElement3, homeScreenElement4, mediaPlayer1, listBox2, label3);
            UIControls.ClientLibInterface.Initialize();
            ClientLib.ClientHandle.ConnectToServer();

            while (!ClientLib.PublicResources.ResourceProvider.isClientConnectedToServer())
                Thread.Sleep(500);
        }

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            { 
                ClientLib.Resources.Services.DataPackage.SendSearchQuery(metroTextBox1.Text);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(metroTextBox1.Text == string.Empty)
            {
                ClientLib.Resources.Services.DataPackage.SendSongListRequest();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(HideSplashScreen)).Start();
            this.BringToFront();
        }

        private void HideSplashScreen()
        {
            Thread.Sleep(900);
            splashScreen.Invoke(new MethodInvoker(delegate () { splashScreen.Hide(); }));
        }
    }
}
