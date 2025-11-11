
using öv4.Classes;
using öv4.Entities;
using öv4.Repo;

var customerRepo = new InMemoryCustomerRepository();
customerRepo.Add(new Customer { Name = "Anna", Email = "a@ex" });
var orderRepo = new InMemoryOrderRepository();
var orderService = new OrderService(customerRepo, orderRepo);
var success = orderService.PlaceOrder(1, "Laptop");
Console.WriteLine($"Order lyckades: {success}");
