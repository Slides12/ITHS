using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRApp.Hubs
{
    public class ChatHub : Hub
    {
        private static Dictionary<string, string> Users = new Dictionary<string, string>();

        public async Task<bool> RegisterUser(string username)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
            {
                await Clients.Caller.SendAsync("ReceiveMessage", "System", $"Registration failed: username is null or empty");
                return false;
            }

            if (Users.ContainsKey(username))
            {
                if (Users[username] == Context.ConnectionId)
                {
                    return true;
                }
                else
                {
                    await Clients.Caller.SendAsync("ReceiveMessage", "System", $"Registration failed: username already exists");
                    return false;

                }
            }

            Users[username] = Context.ConnectionId;
            return true;
        }

        public async Task SendMessage(string user, string message)
        {
            if (!Users.ContainsKey(user) || Users[user] != Context.ConnectionId)
            {
                await Clients.Caller.SendAsync("ReceiveMessage", "System", "You dont have the same connectiond ID as were registered to this user.");
                return;
            }

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendPrivateMessage(string reciever, string sender, string message)
        {
            if (Users[sender] != Context.ConnectionId)
            {
                await Clients.Caller.SendAsync("ReceiveMessage", "System", "You dont have the same connectiond ID as were registered to this user.");
            }
            else if(Users.ContainsKey(reciever))
            {
                await Clients.Client(Users[reciever]).SendAsync("ReceiveMessage", $"Private: {sender}", message);
                await Clients.Caller.SendAsync("ReceiveMessage", $"Private: {sender}", message);
            }
            else
            {
                await Clients.Caller.SendAsync("ReceiveMessage", "System", $"User {reciever} not found or offline.");
            }
        }

    }
}
