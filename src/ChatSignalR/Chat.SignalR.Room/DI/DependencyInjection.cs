using Chat.SignalR.Room.Configuration;
using Chat.SignalR.Room.Connection;
using Chat.SignalR.Room.Hubs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.SignalR.Room.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConnectionServer(this IServiceCollection services)
        {
            services.AddSingleton(typeof(ChatStatus));
            return services;
        }
    }
}
