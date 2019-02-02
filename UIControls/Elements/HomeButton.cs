using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls.Elements
{
    class HomeButton
    {
        public static void HomeButton_Click(object sender, EventArgs e)
        {
            Handler.SetCurrentTab((Button)sender);
            Resources.TabControl.SelectedTab = Resources.HomeTabPage;
        }
    }
}
