using Inlämningsuppgift_1.Entities;

namespace Inlämningsuppgift_1.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        Order? Get(int orderId);
        IEnumerable<Order> GetForUser(int userId);
    }
}
