using TopShop.Domain.Entities;

namespace TopShop.Infrastructure.Interfaces
{
    public interface IProductRepo
    {
        List<Product> GetProducts();

    }
}
