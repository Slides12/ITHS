using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddControllers();

builder.Services.AddOcelot();

builder.Services.AddSwaggerForOcelot(builder.Configuration);


var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
});

app.UseSwaggerForOcelotUI(opt =>
{
    opt.PathToSwaggerGenerator = "/swagger/docs";
});

await app.UseOcelot();

app.Run();
