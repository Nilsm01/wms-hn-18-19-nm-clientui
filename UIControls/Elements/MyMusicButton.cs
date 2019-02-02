using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls.Elements
{
    class MyMusicButton
    {
        public static void MyMusicButton_Click(object sender, EventArgs e)
        {
            Handler.SetCurrentTab((Button)sender);
            Resources.TabControl.SelectedTab = Resources.MyMusicTabPage;
            if (!Updated)
            {
                Handler.SetMyMusic();
                Updated = true;
            }
        }

        private static bool Updated = false;
    }
}
