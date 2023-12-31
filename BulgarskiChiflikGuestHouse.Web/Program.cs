using GuestHouse.BLL.Service;
using GuestHouse.DAL;
using GuestHouse.DAL.Repository;
using GuestHouse.Infrastructure;
using GuestHouse.Web.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("GuestHouseSqlServer");

builder.Services.AddDbContext<GuestHouseDbContext>(options => 
    options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();
builder.Services.AddServices();
builder.Services.AddScoped<IRoomWebService, RoomWebService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IRepository, Repository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app
    .PrepareDatabase()
    .UseHttpsRedirection()
    .UseStaticFiles()
    .UseRouting()
    .UseAuthorization()
    .UseEndpoints(endpoints =>
    {
        endpoints.MapDefaultControllerRoute();
    });

app.Run();
