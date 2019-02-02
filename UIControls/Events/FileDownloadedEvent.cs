using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.UIControls.Events
{
    class FileDownloadedEvent
    {
        public static void Handle(ClientLib.Events.Args.EventArgs.ClientEventArgs args)
        {
            System.Windows.Forms.MessageBox.Show("Das Lied wurde erfolgreich heruntergeladen", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            //MetroFramework.MetroMessageBox.Show(this, "Das Lied wurde erfolgreich heruntergeladen!", "Information", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information, 100)
            Handler.SetMyMusic();

            if(Resources.Element1.FileName == args.List[0])
            {
                Resources.Element1.ButtonText = "Play";
            }
            else if(Resources.Element2.FileName == args.List[0])
            {
                Resources.Element2.ButtonText = "Play";
            }
            else if (Resources.Element3.FileName == args.List[0])
            {
                Resources.Element3.ButtonText = "Play";
            }
            else if (Resources.Element4.FileName == args.List[0])
            {
                Resources.Element4.ButtonText = "Play";
            }
        }
    }
}
