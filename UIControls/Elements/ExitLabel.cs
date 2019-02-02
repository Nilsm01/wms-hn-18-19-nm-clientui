using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.UIControls.Elements
{
    class ExitLabel
    {
        public static void ExitLabel_Click(object sender, EventArgs e)
        {
            ClientLib.UserProfile.Administrator.SaveUserProfile();
            Environment.Exit(0);
        }
    }
}
