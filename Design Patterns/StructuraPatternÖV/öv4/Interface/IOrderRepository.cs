using öv4.Entities;

namespace öv4.Interface
{
    public interface IOrderRepository
    {
        void Add(Order order);
        IEnumerable<Order> GetOrdersByCustomerId(int id);
    }
}
