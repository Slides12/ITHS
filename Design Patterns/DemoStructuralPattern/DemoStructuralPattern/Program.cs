using DemoStructuralPattern.Api.Endpoints;
using DemoStructuralPattern.Core.Interfaces;
using DemoStructuralPattern.Core.Services;
using DemoStructuralPattern.Data.Interface;
using DemoStructuralPattern.Data.Repos;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IStudentRepo, StudentRepo>();






var app = builder.Build();


app.MapStudentEndpoints();


app.Run();
