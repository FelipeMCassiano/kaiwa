using kaiwa.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSignalR();

var app = builder.Build();



app.MapHub<ChatHub>("/hub");

app.Run();
