using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls.Elements
{
    class SongListBox
    {
        public static void DoubleClick(object sender, EventArgs e)
        {
            ListBox songList = (ListBox)sender;
            if(songList.SelectedItem != null && songList.SelectedItem.ToString() != string.Empty)
            {
                if (!File.Exists(Environment.CurrentDirectory + "\\Files\\" + songList.SelectedItem.ToString() + ".mp3"))
                    ClientLib.Resources.Services.DataPackage.SendSongRequest(songList.SelectedItem.ToString());
                else
                    MessageBox.Show("Du hast diese Datei bereits heruntergeladen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
