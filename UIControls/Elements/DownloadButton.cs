using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls.Elements
{
    class DownloadButton
    {
        public static void DownloadButton_Click(object sender, EventArgs e)
        {
            ClientLib.Resources.Services.DataPackage.SendSongListRequest();
            Handler.SetCurrentTab((Button)sender);
            Resources.TabControl.SelectedTab = Resources.DownloadTabPage;
        }
    }
}
