using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace Chat.SignalR.Room.Connection
{
    public static class ConnectionServer 
    {
        static HubConnection _hubConnection;
        public static async void ConnectToHub()
        {
            try
            {
                _hubConnection = new HubConnectionBuilder()
                           .WithAutomaticReconnect()
                           .WithUrl($"{"https://localhost:44339"}{"/ChatServer"}")
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
