using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls.Events
{
    class LastPlayedListUpdatedEvent
    {
        public static void Handle(ClientLib.Events.Args.EventArgs.ClientEventArgs args)
        {
            Resources.LastPlayedList.Invoke(new MethodInvoker(delegate ()
            {
                List<string> rv = ClientLib.PublicResources.ResourceProvider.getUserProfile().ListenedSongs;
                rv.Reverse();
                Resources.LastPlayedList.Items.Clear();
                foreach (string item in rv)
                {
                    Resources.LastPlayedList.Items.Add(item);
                }
            }));
        }
    }
}
