using Microsoft.AspNetCore.SignalR;
using SignalR.Sender;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials()
              .SetIsOriginAllowed(origin => true);
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/sendMessage", async (string? message, IHubContext<SendMessageHub> hub) =>
{
    await hub.Clients.All.SendAsync("ReceiveMessage", message);

    await Task.Delay(1000);
    await hub.Clients.All.SendAsync("ReceiveMessage", "1 second later message");

    await Task.Delay(3000);
    await hub.Clients.All.SendAsync("ReceiveMessage", "3 second later message");

    await Task.Delay(5000);
    await hub.Clients.All.SendAsync("ReceiveMessage", "Finished!");

    return Results.Ok();
});


app.MapHub<SendMessageHub>("/Hub/SendMessage");

app.UseCors();

app.Run();
