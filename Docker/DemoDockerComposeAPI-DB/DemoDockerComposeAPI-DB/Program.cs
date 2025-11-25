using DemoDockerComposeAPI_DB.Data;
using DemoDockerComposeAPI_DB.Data.Interfaces;
using DemoDockerComposeAPI_DB.Data.Repos;
using DemoDockerComposeAPI_DB.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddEndpointsApiExplorer();

var connString = @"Data Source=demodb;Initial Catalog=StudentDB;User ID=sa;Password=Test1234!;TrustServerCertificate=True;";
//var connString = @"Data Source=localhost;Initial Catalog=StudentDB;Integrated Security=true;TrustServerCertificate=True;";

builder.Services.AddDbContext<StudentContext>(
    options => options.UseSqlServer(connString)
    );


builder.Services.AddScoped<IStudentRepo, StudentRepo>();

var app = builder.Build();


app.MapStudentEndpoints();




app.Run();
