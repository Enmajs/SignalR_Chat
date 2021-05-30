using Chat.SignalR.Connection.Configuration;
using Chat.SignalR.Connection.Implementation;
using Chat.SignalR.Connection.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.SignalR.Connection.DI
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection Infraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ChatSettings>(options => configuration.GetSection("ChatSettings").Bind(options));
            return services;
        }

        //public static IServiceCollection ConnectionClient(this IServiceCollection services)
        //{
        //    services.AddSingleton(typeof(IConnectionManager), typeof(ConnectionManager));
        //    return services;
        //}
    }
}
