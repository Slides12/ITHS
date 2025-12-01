using TopShop.Core.Interfaces;
using TopShop.Core.Services;
using TopShop.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddInfrastructure(builder.Configuration);


builder.Services.AddScoped<IProductService, ProductService>();



var app = builder.Build();


app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.Run();
