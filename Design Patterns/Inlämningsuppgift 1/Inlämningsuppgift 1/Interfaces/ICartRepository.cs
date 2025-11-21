using Inlämningsuppgift_1.Services;

namespace Inlämningsuppgift_1.Interfaces
{
    public interface ICartRepository
    {
        public Dictionary<int, List<CartItem>> GetAll();
        public List<CartItem> GetById(int id);
        public void Create(int userId);
        public void DeleteProductInCart(int userId, CartItem product);
        public void ClearCart(int userId);
        public void AddCartItem(int userId, CartItem item);
        void UpdateCartItem(int userId, CartItem item);
    }
}
