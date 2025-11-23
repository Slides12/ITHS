using Inlämningsuppgift_1.Entities;

namespace Inlämningsuppgift_1.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product? GetById(int id);
        void Create(Product product);
        void UpdateProduct(Product p);
    }
}
