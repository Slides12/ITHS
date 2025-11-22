using Inlämningsuppgift_1.Entities;

namespace Inlämningsuppgift_1.Interfaces
{
    public interface IOrderService
    {
        Order CreateOrder(int userId, List<CartItem> items, decimal total);
        Order? Get(int orderId);
        IEnumerable<Order> GetForUser(int userId);
    }
}
