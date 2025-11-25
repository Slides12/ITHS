using Inlämningsuppgift_1.Data.Interfaces;
using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Interfaces;

namespace Inlämningsuppgift_1.Services
{
    public class OrderService : IOrderService
    {
        //1
        //private static readonly List<Order> Orders = new List<Order>();
        private readonly IUnitOfWork _context;

        public OrderService(IUnitOfWork uow)
        {
            _context = uow;
        }

        private static int _nextId = 1;

        //2
        //public class Order
        //{
        //    public int Id { get; set; }
        //    public int UserId { get; set; }
        //    public DateTime CreatedAt { get; set; }
        //    public decimal Total { get; set; }
        //    public List<CartItem> Items { get; set; } = new List<CartItem>(); 
        //}

     
        public Order CreateOrder(int userId, List<CartItem> items, decimal total)
        {
            var o = new Order
            {
                Id = _nextId++,
                UserId = userId,
                CreatedAt = DateTime.UtcNow,
                Items = items,
                Total = total
            };
            _context.Orders.CreateOrder(o);

            _context.Carts.ClearCart(userId);

            return o;
        }

        public Order? Get(int orderId) => _context.Orders.Get(orderId);

        public IEnumerable<Order> GetForUser(int userId) => _context.Orders.GetForUser(userId);
    }
}
