using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Interfaces;

namespace Inlämningsuppgift_1.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> Orders = new List<Order>();

        public void CreateOrder(Order order)
        {
            Orders.Add(order);
        }

        public Order? Get(int orderId)
        {
            var order = Orders.Where(o => o.Id == orderId).FirstOrDefault();
            return order;
        }

        public IEnumerable<Order> GetForUser(int userId)
        {
            var userOrder = Orders.Where(o => o.UserId == userId);

            return userOrder;
        }
    }
}
