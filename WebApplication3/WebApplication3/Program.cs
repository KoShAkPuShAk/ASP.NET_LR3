using System;
using WebApplication3.Interfeces;
using WebApplication3.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICalcService, CalcService>().AddTransient<ITimeService, TimeService>();
var app = builder.Build();

app.MapGet("/1/", async context =>
{
    var calcService = app.Services.GetService<ICalcService>();
    await context.Response.WriteAsync($"Addition - {calcService?.Add(3, 4)}\n");
    await context.Response.WriteAsync($"Multiplication - {calcService?.Multiply(5f, 2f)}\n");
    await context.Response.WriteAsync($"Substraction - {calcService?.Substract(4, 2)}\n");
    await context.Response.WriteAsync($"Division - {calcService?.Divide(2.0, 3.0)}\n");
});

app.MapGet("/2/", async context =>
{
    var dayTimeService = app.Services.GetService<ITimeService>();
    await context.Response.WriteAsync($"Time of the day - {dayTimeService?.TimeOfDay(DateTime.Now)}\n");
});

app.Run();