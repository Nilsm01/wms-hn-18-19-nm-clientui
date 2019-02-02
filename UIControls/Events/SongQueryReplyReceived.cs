using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls.Events
{
    class SongQueryReplyReceived
    {
        public static void Handle(ClientLib.Events.Args.EventArgs.ClientEventArgs args)
        {
            // Wenn keine Suchergebnisse gefunden wurde, so ist das string Array args.SongList, Index[0] gleich string.Empty
            if (args.List[0] != string.Empty)
            {
                Resources.SongList.Invoke(new MethodInvoker(delegate ()
                {
                    Resources.SongList.Items.Clear();
                    Resources.SongList.Items.AddRange(args.List);
                }));
            }
            else
            {
                Resources.SongList.Invoke(new MethodInvoker(delegate ()
                {
                    Resources.SongList.Items.Clear();
                    Resources.SongList.Items.Add("Keine Suchergebnisse!");
                }));
            }
        }
    }
}
