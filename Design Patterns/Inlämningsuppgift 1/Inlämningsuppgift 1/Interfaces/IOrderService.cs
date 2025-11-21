using Inlämningsuppgift_1.Services;
using static Inlämningsuppgift_1.Services.OrderService;

namespace Inlämningsuppgift_1.Interfaces
{
    public interface IOrderService
    {
        Order CreateOrder(int userId, List<CartItem> items, decimal total);
        Order? Get(int orderId);
        IEnumerable<Order> GetForUser(int userId);
    }
}
