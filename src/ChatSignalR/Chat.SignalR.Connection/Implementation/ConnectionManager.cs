using Chat.SignalR.Connection.Configuration;
using Chat.SignalR.Connection.Interface;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Chat.SignalR.Connection.Implementation
{
    public class ConnectionManager : IConnectionManager
    {
        private HubConnection _hubConnection;
        private readonly ChatSettings _chatSettings;


        public ConnectionManager(IOptions<ChatSettings> chatSettings)
        {
            _chatSettings = chatSettings.Value;
            ConnectToHub();
        }

        public async void  ConnectToHub()
        {
            try
            {
                _hubConnection = new HubConnectionBuilder()
                           .WithAutomaticReconnect()
                           .WithUrl($"{_chatSettings.UrlHub}{_chatSettings.HubRoute}")
                           .Build();
                await _hubConnection.StartAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
