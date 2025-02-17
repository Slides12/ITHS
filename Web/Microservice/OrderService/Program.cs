var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Order> orders = new(){
    new Order() { Id= 1, Status = "Pending", Quantity = 2},
    new Order() { Id= 2, Status = "Completed", Quantity = 5},
};

app.MapGet("/orders", () => {
    return orders;
});

app.MapGet("/orders/{id}", (int id) => {
    var order = orders.FirstOrDefault(o => o.Id == id);

    if(order is null){
        return Results.NotFound("Order not found.");
    }

    return Results.Ok(order);
});

app.MapPost("/orders", (Order newOrder) => {
    if(newOrder is null){
        return Results.NotFound("Order not found.");
    }

    orders.Add(newOrder);
    return Results.Created($"/orders/{newOrder.Id}", newOrder);
});



app.Run();



class Order{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public required string Status { get; set; }
}