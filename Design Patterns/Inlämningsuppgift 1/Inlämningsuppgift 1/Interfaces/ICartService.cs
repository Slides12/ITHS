using Inlämningsuppgift_1.Services;

namespace Inlämningsuppgift_1.Interfaces
{
    public interface ICartService
    {
        void AddToCart(int userId, int productId, int quantitye);
        IEnumerable<CartItem> GetCartForUser(int userId);
        void RemoveFromCart(int userId, int productId);
        void ClearCart(int userId);
    }
}
