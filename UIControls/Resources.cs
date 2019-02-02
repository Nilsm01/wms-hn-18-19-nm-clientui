using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls
{
    class Resources
    {
        public static Panel CurrentTab { get; set; }
        public static TabControl TabControl { get; set; }
        public static TabPage HomeTabPage { get; set; }
        public static TabPage DownloadTabPage { get; set; }
        public static TabPage MyMusicTabPage { get; set; }
        public static TabPage SettingsTabPage { get; set; }
        public static Label ExitLabel { get; set; }
        public static ListBox SongList { get; set; }
        public static HomeScreenElement Element1 { get; set; }
        public static HomeScreenElement Element2 { get; set; }
        public static HomeScreenElement Element3 { get; set; }
        public static HomeScreenElement Element4 { get; set; }
        public static MediaPlayer Player { get; set; }
        public static ListBox LastPlayedList { get; set; }
        public static List<MusicElementContainer> MyMusicElements { get; set; }
        public static Label PercentageLabel { get; set; }
        public static int DownloadPercentage { get; set; }
        public static Form HandlingForm { get; set; }
    }
}
