using DiEx.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITimeService, TimeService>();
builder.Services.AddScoped<ITimeService, SecondTimeService>();

var app = builder.Build();



app.MapGet("/", (ITimeService timeService) => $"CurrentTime: {timeService.GetCurrentTime()}");

app.Run();
