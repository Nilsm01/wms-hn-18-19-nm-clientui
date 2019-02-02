using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls
{
    class Handler
    {
        public static void Initialize(Form HandlingForm, Button homeButton, Button downloadButton, Button myMusicButton, Button settingsButton, TabControl tabControl, TabPage homeTabPage, TabPage downloadTabPage, TabPage myMusicTabPage, TabPage settingsTabPage, Panel currentTab, Label exitLabel, ListBox songList, HomeScreenElement Element1, HomeScreenElement Element2, HomeScreenElement Element3, HomeScreenElement Element4, MediaPlayer mediaPlayer, ListBox LastPlayedList, Label Percentage)
        {
            homeButton.Click += Elements.HomeButton.HomeButton_Click;
            downloadButton.Click += Elements.DownloadButton.DownloadButton_Click;
            myMusicButton.Click += Elements.MyMusicButton.MyMusicButton_Click;
            settingsButton.Click += Elements.SettingsButton.SettingsButton_Click;
            exitLabel.Click += Elements.ExitLabel.ExitLabel_Click;
            songList.DoubleClick += Elements.SongListBox.DoubleClick;

            Resources.HandlingForm = HandlingForm;
            Resources.CurrentTab = currentTab;
            Resources.TabControl = tabControl;
            Resources.HomeTabPage = homeTabPage;
            Resources.DownloadTabPage = downloadTabPage;
            Resources.MyMusicTabPage = myMusicTabPage;
            Resources.SettingsTabPage = settingsTabPage;
            Resources.SongList = songList;
            Resources.Element1 = Element1;
            Resources.Element2 = Element2;
            Resources.Element3 = Element3;
            Resources.Element4 = Element4;
            Resources.Player = mediaPlayer;
            Resources.LastPlayedList = LastPlayedList;
            Resources.PercentageLabel = Percentage;
            Resources.DownloadPercentage = 0;

            Resources.ExitLabel = exitLabel;

            Resources.MyMusicTabPage.AutoScroll = true;
            Resources.TabControl.SelectedTab = Resources.HomeTabPage;
        }

        public static void SetMyMusic()
        {
            if (Resources.MyMusicElements != null)
            {
                foreach (MusicElementContainer item in Resources.MyMusicElements)
                {
                    Resources.MyMusicTabPage.Invoke(new MethodInvoker(delegate () { Resources.MyMusicTabPage.Controls.Remove(item); }));
                    //item.Invoke(new MethodInvoker(delegate () { item.Dispose(); }));
                }
            }
            Resources.MyMusicElements = new List<MusicElementContainer>();
            int X = 10;
            int Y = 10;
            MusicElementContainer bufferContainer = new MusicElementContainer();

            foreach (string item in Directory.GetFiles(Environment.CurrentDirectory + "\\Files"))
            {
                bufferContainer = new MusicElementContainer();
                bufferContainer.Location = new System.Drawing.Point(X, Y);
                Resources.MyMusicTabPage.Invoke(new MethodInvoker(delegate () { Resources.MyMusicTabPage.Controls.Add(bufferContainer); }));             
                Y += bufferContainer.Height + 1;
                bufferContainer.SongName = Path.GetFileNameWithoutExtension(item);
                Resources.MyMusicElements.Add(bufferContainer);
            }
        }

        public static void SetCurrentTab(Button currentButton)
        {
            Resources.CurrentTab.Height = currentButton.Height;
            Resources.CurrentTab.Top = currentButton.Top;
        }
    }
}
