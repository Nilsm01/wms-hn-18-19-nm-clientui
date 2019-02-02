using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.UIControls.Events
{
    class DownloadPercentageChanged
    {
        public static void Handle(ClientLib.Events.Args.EventArgs.ClientEventArgs args)
        {
            Resources.DownloadPercentage++;
            if (Resources.DownloadPercentage != 100) {
                Resources.PercentageLabel.Invoke(new System.Windows.Forms.MethodInvoker(delegate () { Resources.PercentageLabel.Text = Resources.DownloadPercentage.ToString() + "%"; }));
            }
            else
            {
                Resources.DownloadPercentage = 0;
                FadePercentageLabelOut();
            }
        }

        private static void FadePercentageLabelOut()
        {
            System.Threading.Thread.Sleep(1000);
            Resources.PercentageLabel.Invoke(new System.Windows.Forms.MethodInvoker(delegate () { Resources.PercentageLabel.Text = string.Empty; }));
        }
    }
}
