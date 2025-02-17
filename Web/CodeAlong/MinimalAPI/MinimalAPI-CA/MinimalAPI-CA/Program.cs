using Microsoft.Extensions.DependencyInjection;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();

}

app.MapGet("/", () => "Hello World!");

app.MapGet("/test", () => "Test complete");

app.MapGet("/test/{id}", (int id) =>
{
    return Results.Ok(id);
});

app.MapPost("/test", (int test) =>
{
    return Results.Ok();
});



app.Run();
