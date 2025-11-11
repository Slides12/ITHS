using öv4.Interface;
using öv4.Entities;
using öv4.Interface;

namespace öv4.Classes
{
    public class OrderService
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IOrderRepository _orderRepo;
        public OrderService(ICustomerRepository customerRepo, IOrderRepository
       orderRepo)
        {
            _customerRepo = customerRepo;
            _orderRepo = orderRepo;
        }
        public bool PlaceOrder(int customerId, string product)
        {
            var customer = _customerRepo.GetById(customerId);
            if (customer == null) return false;
            var order = new Order { CustomerId = customerId, Product = product };
            _orderRepo.Add(order);

            Console.WriteLine($"Order skapad för kund {customer.Name}: {product}");
            return true;
        }
    }

}
