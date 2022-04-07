using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorWebAssemblySignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string user, string message)
        {

            return Clients.All.SendAsync("ReceivingMessageFromAUser", user, message);
        }
        public Task SendMessageToCaller(string user, string message)
        {
            return Clients.Caller.SendAsync("ReceivingMessageFromAUser", user + " something special", message);
        }
        public Task SendMessageToGroup(string user, string message)
        {
            return Clients.Group("SignalR Users").SendAsync("ReceivingMessageFromAUser", user, message);
        }
    }
}
