using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.UIControls
{
    class ClientLibInterface
    {
        public static void Initialize()
        {
            ClientLib.Events.ClientEvents.ConnectedToServer.ConnectedToServerEvent += Events.ConnectedToServerEvent.Handle;
            ClientLib.Events.ClientEvents.SongList.SongListEvent += Events.SongListReceivedEvent.Handle;
            ClientLib.Events.ClientEvents.DownloadPercentageChanged.DownloadPercentageChangedEvent += Events.DownloadPercentageChanged.Handle;
            ClientLib.Events.ClientEvents.FileDownloaded.FileDownloadedEvent += Events.FileDownloadedEvent.Handle;
            ClientLib.Events.ClientEvents.SongQuery.SongQueryEvent += Events.SongQueryReplyReceived.Handle;
            ClientLib.Events.ClientEvents.HomeScreen.HomeScreenReceivedEvent += Events.HomeScreenReceivedEvent.Handle;
            ClientLib.Events.ClientEvents.LasPlayedListUpdated.LastPlayedListUpdatedEvent += Events.LastPlayedListUpdatedEvent.Handle;
            ClientLib.Events.DataPackageEvents.DataExchangeReceived.DataExchangeReceivedEvent += Events.DataExchangeReceivedEvent.Handle;
            ClientLib.Events.ErrorEvents.ConnectionError.ConnectionErrorEvent += Events.ConnectionErrorEvent.Handle;
            ClientLib.Events.ErrorEvents.EvaluationError.EvaluationErrorEvent += Events.EvaluationErrorEvent.Handle;
            ClientLib.Events.ErrorEvents.LoginFailed.LoginFailedEvent += Events.LoginFailedEvent.Handle;
            ClientLib.Events.ErrorEvents.NetworkStreamError.NetworkStreamErrorEvent += Events.NetworkStreamErrorEvent.Handle;
            ClientLib.Events.ServerEvents.FileNotFound.FileNotFoundEvent += Events.FileNotFoundEvent.Handle;
            ClientLib.Events.ServerEvents.PermissonError.PermissionErrorEvent += Events.PermissionErrorEvent.Handle;
        }
    }
}
