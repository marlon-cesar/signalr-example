using Microsoft.AspNetCore.SignalR;
using SignalR.Sender;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/sendMessage", () =>
{
   
});


app.MapHub<SendMessageHub>("/SendMessageHub");

app.Run();
