var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(config =>
{
 config.DocumentName = "Minimal API";
 config.Title = "MinimalAPI v1";
 config.Version = "v1";
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
 app.UseOpenApi();
 app.UseSwaggerUi(config =>
 {
  config.DocumentTitle = "MinimalAPI";
  config.Path = "/swagger";
  config.DocumentPath = "/swagger/{documentName}/swagger.json";
  config.DocExpansion = "list";
 });
}

var httpClient = new HttpClient();


// OrderService = 5043

// ProductService = 5230


app.MapGet("/gateway/orders", async () => {
    return await httpClient.GetStringAsync("http://localhost:5043/orders");
});



app.Run();
 