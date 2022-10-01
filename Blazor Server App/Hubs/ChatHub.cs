using Microsoft.AspNetCore.SignalR;

namespace Blazor_Server_App.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message ,string user)
        {
            await Clients.All.SendAsync("ReceiveMessage", message,user);
        }
    }
}
