using Inlämningsuppgift_1.Interfaces;
using Inlämningsuppgift_1.Repository;

namespace Inlämningsuppgift_1.Services
{
    public class CartService : ICartService
    {
      
        //3
        //private static readonly Dictionary<int, List<CartItem>> Carts = new Dictionary<int, List<CartItem>>();
        
        //1
        private readonly IProductService _productService;
        private readonly ICartRepository _cartRepository;

        public CartService(IProductService productService, ICartRepository cartRepository)
        {
            this._productService = productService;
            this._cartRepository = cartRepository;
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

            var list = _cartRepository.GetById(userId);
            if (list == null)
            {
                _cartRepository.Create(userId);
                list = _cartRepository.GetById(userId);
            }

            var existing = list.FirstOrDefault(ci => ci.ProductId == productId);

            var product = _productService.GetById(productId);

            if (product == null)
                Console.WriteLine("Product not found");

            if (existing == null) _cartRepository.AddCartItem(userId,
                new CartItem { 
                    ProductId = productId, 
                    Quantity = quantity,
                    UnitPrice = product?.Price ?? 0,
                    ProductName = product?.Name ?? "Unknown"
                });
            else existing.Quantity += quantity;
        }

        public IEnumerable<CartItem> GetCartForUser(int userId)
        {
            //if (!Carts.ContainsKey(userId)) return Enumerable.Empty<CartItem>();
            //return Carts[userId];

            var list = _cartRepository.GetById(userId);
            if (list == null) _cartRepository.Create(userId);

            return list;
        }

        public void RemoveFromCart(int userId, int productId)
        {
            //if (!Carts.ContainsKey(userId)) return;
            //var list = Carts[userId];

            var list = _cartRepository.GetById(userId);
            if (list == null) return;

            var existing = list.FirstOrDefault(ci => ci.ProductId == productId);
            if (existing != null) _cartRepository.DeleteProductInCart(userId, existing);
        }

        public void ClearCart(int userId)
        {
            //if (Carts.ContainsKey(userId)) Carts[userId].Clear();
            if(_cartRepository.GetById(userId) != null)
                _cartRepository.ClearCart(userId);
        }
    }
}
