using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI.UIControls.Events
{
    class HomeScreenReceivedEvent
    {
        public static void Handle(ClientLib.Events.Args.EventArgs.ClientEventArgs args)
        {
            Console.WriteLine("Evaluating");
            Resources.Element1.Invoke(new MethodInvoker(delegate ()
            {
                string[] element1 = ClientLib.PublicResources.ResourceProvider.getHomeScreen_Item1();
                Resources.Element1.SongName.Text = element1[0];
                CheckSongNameLength(Resources.Element1.SongName);
                Resources.Element1.FileName = element1[2];
                Resources.Element1.DownloadPicture(element1[1], 1);                
            }));

            Resources.Element2.Invoke(new MethodInvoker(delegate ()
            {
                string[] element2 = ClientLib.PublicResources.ResourceProvider.getHomeScreen_Item2();
                Resources.Element2.SongName.Text = element2[0];
                CheckSongNameLength(Resources.Element2.SongName);
                Resources.Element2.FileName = element2[2];
                Resources.Element2.DownloadPicture(element2[1], 2);
            }));

            string[] element3 = ClientLib.PublicResources.ResourceProvider.getHomeScreen_Item3();
            Resources.Element3.Invoke(new MethodInvoker(delegate ()
            {
                Resources.Element3.SongName.Text = element3[0];
                CheckSongNameLength(Resources.Element3.SongName);
                Resources.Element3.FileName = element3[2];
                Resources.Element3.DownloadPicture(element3[1], 3);
            }));

            Resources.Element4.Invoke(new MethodInvoker(delegate ()
            {
                string[] element4 = ClientLib.PublicResources.ResourceProvider.getHomeScreen_Item4();
                Resources.Element4.SongName.Text = element4[0];
                CheckSongNameLength(Resources.Element4.SongName);
                Resources.Element4.FileName = element4[2];
                Resources.Element4.DownloadPicture(element4[1], 4);
            }));

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

        private static void CheckSongNameLength(Label label)
        { 
            if (label.Text.Length >= 16)
            {
                int index = label.Text.Length - 15;
                label.Text = label.Text.Remove(label.Text.Length - index);
                label.Text += "...";
            }
        }

    }
}
