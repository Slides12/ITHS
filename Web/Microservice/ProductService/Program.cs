var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Product> products = new List<Product>() {
    new Product() { Id=1, Name="laptop", Stock=3},
    new Product() { Id=2, Name="Phone", Stock=23}
};

app.MapGet("/products", () => products);

app.MapGet("/products/{id}", (int id) => {
    Product? prod = products.FirstOrDefault(p => p.Id == id);

    if(prod is null){
        return Results.NotFound("Product not found.");
    }
    return Results.Ok(prod);
});


app.Run();


class Product {
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Stock { get; set; }
}