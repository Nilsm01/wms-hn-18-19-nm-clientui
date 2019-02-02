using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.UIControls.Events
{
    class PermissionErrorEvent
    {
        public static void Handle(ClientLib.Events.Args.EventArgs.ServerEventArgs args)
        {
            //MetroFramework.MetroMessageBox.Show(Resources.HandlingForm, args.Param, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information, 120);
            System.Windows.Forms.MessageBox.Show(args.Param, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
