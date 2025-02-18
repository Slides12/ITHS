using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Order> orders = new List<Order>(){
    new Order() {Id=1, OrderItem="Hammare", Quantity=3, IsAvailable=true },
    new Order() {Id=2, OrderItem="Skruvmejsel", Quantity=31, IsAvailable=true },
    new Order() {Id=3, OrderItem="Skruv", Quantity=13, IsAvailable=true },
    new Order() {Id=4, OrderItem="Spik", Quantity=35, IsAvailable=true },
};

app.MapGet("/GetAllOrders", () => {return orders;});
app.MapGet("/GetOrder/{id}", (int id) => {
    var order = orders.FirstOrDefault(o => o.Id == id);
    if(order is null) return Results.NotFound();

    return Results.Ok(order);
    });


app.MapPost("/PostOrder", (Order newOrder) => {
    if(newOrder is null) return Results.NotFound();

    var maxIndex = orders.Max(o => o.Id);
    newOrder.Id = maxIndex + 1;
    orders.Add(newOrder);
    return Results.Created($"/GetOrder/{newOrder.Id}",newOrder);
});

app.MapPut("/PutOrder/{id}", (int id, Order updateOrder) => {
    if(updateOrder.OrderItem is null) return Results.BadRequest("Atleast add a OrderItem");

    var existingOrder = orders.FirstOrDefault(o => o.Id == id);
    if(existingOrder is null) return Results.NotFound();

    existingOrder.IsAvailable = updateOrder.IsAvailable;
    existingOrder.OrderItem = updateOrder.OrderItem;
    existingOrder.Quantity = updateOrder.Quantity;

    return Results.Accepted($"/PutOrder/{existingOrder.Id}",existingOrder);

});


app.MapDelete("/DeleteOrder/{id}", (int id) => {
    var order = orders.FirstOrDefault(o => o.Id == id);
    if(order is null) return Results.NotFound();

    orders.Remove(order);
    return Results.NoContent();
});

app.Run();


public class Order{
    public int Id { get; set; }
    public required string OrderItem { get; set; }
    public int Quantity { get; set; }
    public bool IsAvailable { get; set; }
}