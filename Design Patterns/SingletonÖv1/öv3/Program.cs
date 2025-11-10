using Microsoft.Extensions.DependencyInjection;
using öv3.Classes;
using öv3.Interface;




var services = new ServiceCollection();

services.AddTransient<INotifier, SMSNotifier>();
services.AddTransient<OrderService>();


var provider = services.BuildServiceProvider();


var orderService = provider.GetRequiredService<OrderService>();

orderService.ProcessOrder();