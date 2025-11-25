using Inlämningsuppgift_1.Interfaces;

namespace Inlämningsuppgift_1.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        ICartRepository Carts { get; }

    }
}
