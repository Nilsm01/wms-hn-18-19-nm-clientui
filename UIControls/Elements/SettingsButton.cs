using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls.Elements
{
    class SettingsButton
    {
        public static void SettingsButton_Click(object sender, EventArgs e)
        {
            Handler.SetCurrentTab((Button)sender);
            Resources.TabControl.SelectedTab = Resources.SettingsTabPage;
        }
    }
}
