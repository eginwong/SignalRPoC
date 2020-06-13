using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }

        public void SendToOthers(string name, string message)
        {
            // Call the broadcastMessage method to update other clients.
            Clients.Others.broadcastMessage(name, message);
        }

        public void SendDiagnostics()
        {
            // Call the broadcastMessage method to update other clients.
            Clients.All.diagnostics(Context.ConnectionId);
        }
    }
}