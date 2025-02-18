using System.Net;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Scalar.AspNetCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

HttpClient httpClient = new HttpClient();


// Orders

app.MapGet("/gateway/GetAllOrders", async () =>{
    return await httpClient.GetStringAsync("http://localhost:5154/GetAllOrders");
});

app.MapGet("/gateway/GetOrder/{id}", async (int id) =>
{
    var response = await httpClient.GetAsync($"http://localhost:5154/GetOrder/{id}");

    if (response.IsSuccessStatusCode)
    {
        var content = await response.Content.ReadAsStringAsync();
        return Results.Ok(content);
    }
    else
    {
        return Results.NotFound($"Order with ID {id} not found.");
    }
});


app.MapPost("/gateway/PostOrder", async (Order order) => 
{
    if (order is null) return Results.NotFound();

    var response = await httpClient.PostAsJsonAsync("http://localhost:5154/PostOrder", order);

    return response.IsSuccessStatusCode 
        ? Results.Ok() 
        : Results.StatusCode((int)response.StatusCode);
});

app.MapPut("/gateway/PutOrder/{id}", async (int id, Order updateOrder) => {
    var response = await httpClient.PutAsJsonAsync($"http://localhost:5154/PutOrder/{id}", updateOrder);

    return response.IsSuccessStatusCode 
        ? Results.Ok() 
        : Results.StatusCode((int)response.StatusCode);
});


// Products

app.MapGet("/gateway/GetAllProducts", async () =>{
    return await httpClient.GetStringAsync("http://localhost:5016/GetAllProducts");
});

app.MapPost("/gateway/PostProduct", async (Product product) => 
{
    if (product is null) return Results.NotFound();

    var response = await httpClient.PostAsJsonAsync("http://localhost:5016/PostProduct", product);

    return response.IsSuccessStatusCode 
        ? Results.Ok() 
        : Results.StatusCode((int)response.StatusCode);
});


app.MapDelete("/gateway/DeleteProduct/{id}", async (int id) => {
    var response = await httpClient.DeleteAsync($"http://localhost:5016/DeleteProduct/{id}");

    return response.IsSuccessStatusCode 
        ? Results.Ok() 
        : Results.StatusCode((int)response.StatusCode);
});

app.Run();


public class Order{
    public int Id { get; set; }
    public required string OrderItem { get; set; }
    public int Quantity { get; set; }
    public bool IsAvailable { get; set; }
}


class Product{
    public int Id { get; set; }
    public required string ProductName { get; set; }
    public int Price { get; set; }
    public string? Category { get; set; }
}