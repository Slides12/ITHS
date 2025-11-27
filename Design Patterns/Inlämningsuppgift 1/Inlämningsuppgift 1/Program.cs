using Inlämningsuppgift_1;
using Inlämningsuppgift_1.Data.Data;
using Inlämningsuppgift_1.Data.Interfaces;
using Inlämningsuppgift_1.Data.Repository;
using Inlämningsuppgift_1.Interfaces;
using Inlämningsuppgift_1.Repository;
using Inlämningsuppgift_1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddServices();


builder.Services.AddSingleton<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => {  endpoints.MapControllers(); });

app.Run();

