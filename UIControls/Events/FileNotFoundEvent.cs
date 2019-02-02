using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.UIControls.Events
{
    class FileNotFoundEvent
    {
        public static void Handle(ClientLib.Events.Args.EventArgs.ServerEventArgs args)
        {
            System.Windows.Forms.MessageBox.Show("Fehler beim Download, die Datei konnte nicht auf dem Server gefunden werden!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); 
        }
    }
}
