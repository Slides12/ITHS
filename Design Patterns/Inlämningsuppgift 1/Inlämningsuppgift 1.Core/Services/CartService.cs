using Inlämningsuppgift_1.Data.Interfaces;
using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Interfaces;
using Inlämningsuppgift_1.Repository;

namespace Inlämningsuppgift_1.Services
{
    public class CartService : ICartService
    {

        //3
        //private static readonly Dictionary<int, List<CartItem>> Carts = new Dictionary<int, List<CartItem>>();

        //1
        private readonly IUnitOfWork _context;

        public CartService(IUnitOfWork uow)
        {
            _context = uow;
        }

        //2

        //public class CartItem
        //{
        //    public int ProductId { get; set; }
        //    public int Quantity { get; set; }
        //    public decimal UnitPrice { get; set; }
        //    public string ProductName { get; set; }
        //}


        public void AddToCart(int userId, int productId, int quantity)
        {
            //if (!Carts.ContainsKey(userId)) Carts[userId] = new List<CartItem>();
            //var list = Carts[userId];

            var product = _context.Products.GetById(productId);

            if (product == null)
                return;

            if (quantity <= 0)
                return;

            if (product.Stock < quantity)
                return;

            var list = _context.Carts.GetById(userId);
            if (list == null)
            {
                _context.Carts.Create(userId);
                list = _context.Carts.GetById(userId);
            }

            var existing = list.FirstOrDefault(ci => ci.ProductId == productId);


            if (existing == null) _context.Carts.AddCartItem(userId,
                new CartItem { 
                    ProductId = productId, 
                    Quantity = quantity,
                    UnitPrice = product?.Price ?? 0,
                    ProductName = product?.Name ?? "vemVet"
                });
            else
            {
                existing.Quantity += quantity;
                _context.Carts.UpdateCartItem(userId, existing);
            } 
        }

        public decimal GetCartTotal(int userId)
        {
            var list = _context.Carts.GetById(userId);
            if (list == null) return 0;
            decimal total = 0;
            foreach (var ci in list)
            {
                total += ci.UnitPrice * ci.Quantity;
            }
            return total;
        }

        public IEnumerable<CartItem> GetCartForUser(int userId)
        {
            //if (!Carts.ContainsKey(userId)) return Enumerable.Empty<CartItem>();
            //return Carts[userId];

            var list = _context.Carts.GetById(userId);
            if (list == null)
            {
                _context.Carts.Create(userId);
                list = _context.Carts.GetById(userId);
            }
            return list;
        }

        public void RemoveFromCart(int userId, int productId)
        {
            //if (!Carts.ContainsKey(userId)) return;
            //var list = Carts[userId];

            var list = _context.Carts.GetById(userId);
            if (list == null) return;

            var existing = list.FirstOrDefault(ci => ci.ProductId == productId);
            if (existing != null) _context.Carts.DeleteProductInCart(userId, existing);
        }

        public void ClearCart(int userId)
        {
            //if (Carts.ContainsKey(userId)) Carts[userId].Clear();
            if(_context.Carts.GetById(userId) != null)
                _context.Carts.ClearCart(userId);
        }
    }
}
