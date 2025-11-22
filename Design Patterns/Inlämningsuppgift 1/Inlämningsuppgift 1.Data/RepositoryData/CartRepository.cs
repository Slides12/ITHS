using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Interfaces;

namespace Inlämningsuppgift_1.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly Dictionary<int, List<CartItem>> Carts = new Dictionary<int, List<CartItem>>();

        public void AddCartItem(int userId, CartItem item)
        {
            if(userId > 0 || item != null)
                Carts[userId].Add(item);
        }

        public void ClearCart(int userId)
        {
            if (Carts.TryGetValue(userId, out var list))
                Carts.Remove(userId);
        }

        public void Create(int userId)
        {
            if(userId > 0)
                Carts.Add(userId, new List<CartItem>());
        }

        public void DeleteProductInCart(int userId, CartItem product)
        {
            if (!Carts.TryGetValue(userId, out var list) ||product == null)
                return;
            Carts[userId].Remove(product);
        }

        public void UpdateCartItem(int userId, CartItem item)
        {
            if (!Carts.TryGetValue(userId, out var list) || item == null)
                return;
            var existing = Carts[userId].FirstOrDefault(ci => ci.ProductId == item.ProductId);
            if (existing != null)
            {
                existing.Quantity = item.Quantity;
                existing.UnitPrice = item.UnitPrice;
                existing.ProductName = item.ProductName;
            }
        }

        public Dictionary<int, List<CartItem>> GetAll()
        {
            return Carts;
        }

        public List<CartItem> GetById(int id)
        {
            if (!Carts.TryGetValue(id, out var list))
                return null;

            return Carts[id];
        }
     
    }
}
