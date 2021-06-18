using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace signalRChatApp.SignalR
{
    public class SignalRChatHub : Hub
    {
        public void Broadcastmessage(String user,String message)
        {
            Clients.All.ReceiveMessage(user,message);
            
        }
    }
}