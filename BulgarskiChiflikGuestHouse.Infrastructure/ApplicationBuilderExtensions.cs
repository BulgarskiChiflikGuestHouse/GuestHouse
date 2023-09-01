using GuestHouse.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GuestHouse.Infrastructure
{
	public static class ApplicationBuilderExtensions
	{
		public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app) 
		{
			var serviceScope = app.ApplicationServices.CreateScope();
			var service = serviceScope.ServiceProvider;

			MigrateDatabase(service);

			return app;
		}

		private static void MigrateDatabase(IServiceProvider service)
		{
			var data = service.GetRequiredService<GuestHouseDbContext>();
			data.Database.Migrate();
		}
	}
}
