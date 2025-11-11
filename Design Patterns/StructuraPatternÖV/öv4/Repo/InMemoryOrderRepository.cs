using öv4.Entities;
using öv4.Interface;

namespace öv4.Repo
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();
        private int _nextId = 1;
        public void Add(Order order) { order.Id = _nextId++; _orders.Add(order); }
        public IEnumerable<Order> GetOrdersByCustomerId(int customerId) =>
       _orders.Where(o => o.CustomerId == customerId);
    }

}
