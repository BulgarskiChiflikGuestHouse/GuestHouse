using GuestHouse.BLL.Service;
using GuestHouse.DAL.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GuestHouse.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}
