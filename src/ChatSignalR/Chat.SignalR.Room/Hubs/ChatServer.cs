using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Chat.SignalR.Room.Hubs
{
    public class ChatServer : Hub
    {
        private readonly ChatStatus _chatStatus;

        public ChatServer(ChatStatus chatStatus)
        {
            _chatStatus = chatStatus;
        }

        public override async Task OnConnectedAsync()
        {
            var parameters = GetParametersRequest();

            if (!string.IsNullOrEmpty(parameters.user) && !string.IsNullOrEmpty(parameters.room))
            {
                await AddConnectionToHub(parameters.user, parameters.room);
            }
            await base.OnConnectedAsync();
        }

        protected (string user, string room) GetParametersRequest() => (
                  Context.GetHttpContext().Request.Query["user"].ToString() ?? string.Empty,
                  Context.GetHttpContext().Request.Query["room"].ToString() ?? string.Empty);


        public async Task AddConnectionToHub(string user, string room)
        {
            switch (user)
            {
                case "guest":
                    _chatStatus.Connections.Add(Context.ConnectionId);
                    await Groups.AddToGroupAsync(Context.ConnectionId, room);
                    break;
                default:
                    break;
            }
        }
    }
}
