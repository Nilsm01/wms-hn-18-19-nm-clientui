using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.UIControls.Events
{
    class SongListReceivedEvent
    {
        public static void Handle(ClientLib.Events.Args.EventArgs.ClientEventArgs args)
        {
            Resources.SongList.Invoke(new System.Windows.Forms.MethodInvoker(delegate ()
            {
                Resources.SongList.Items.Clear();
                Resources.SongList.Items.AddRange(args.List);
                /*
                for (int i = 0; i < args.SongList.Length; i++)
                {
                    Resources.SongList.Items.Add(args.SongList[i]);
                }
                */
            }));
        }
    }
}
