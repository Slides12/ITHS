var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Product> products = new List<Product>(){
    new Product() { Id=1, ProductName="Hammare", Category="Verktyg", Price=199},
    new Product() { Id=2, ProductName="Skruvmejsel", Category="Verktyg", Price=99},
    new Product() { Id=3, ProductName="Skruv", Category="Tillbehör", Price=19},
    new Product() { Id=4, ProductName="Spik", Category="Tillbehör", Price=25},
};

app.MapGet("/GetAllProducts", () => {return products;});
app.MapGet("/GetProduct/{id}", (int id) => {
    var order = products.FirstOrDefault(o => o.Id == id);
    if(order is null) return Results.NotFound();

    return Results.Ok(order);
    });


app.MapPost("/PostProduct", (Product newProduct) => {
    if(newProduct is null) return Results.NotFound();

    var maxIndex = products.Max(o => o.Id);
    newProduct.Id = maxIndex + 1;
    products.Add(newProduct);
    return Results.Created($"/GetOrder/{newProduct.Id}",newProduct);
});

app.MapPut("/PutProduct/{id}", (int id, Product updateProduct) => {
    if(updateProduct.ProductName is null) return Results.BadRequest("Atleast add a ProductName");

    var existingProduct = products.FirstOrDefault(o => o.Id == id);
    if(existingProduct is null) return Results.NotFound();

    existingProduct.ProductName = updateProduct.ProductName;
    existingProduct.Price = updateProduct.Price;
    existingProduct.Category = updateProduct.Category;

    return Results.NoContent();

});


app.MapDelete("/DeleteProduct/{id}", (int id) => {
    var order = products.FirstOrDefault(o => o.Id == id);
    if(order is null) return Results.NotFound();

    products.Remove(order);
    return Results.NoContent();
});

app.Run();


class Product{
    public int Id { get; set; }
    public required string ProductName { get; set; }
    public int Price { get; set; }
    public string? Category { get; set; }
}