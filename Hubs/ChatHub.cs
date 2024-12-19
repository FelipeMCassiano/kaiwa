using Microsoft.AspNetCore.SignalR;

namespace kaiwa.Hubs;

public class ChatHub : Hub<IChatClient>
{

    public async Task SendMessage(string user, string message) => await Clients.All.ReceiveMessage(user, message);

    public async Task<string> WaitForMessage(string connectionId)
    {
        var message = await Clients.Client(connectionId).GetMessage();

        return message;
    }


};
