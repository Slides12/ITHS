using Inlämningsuppgift_1.Entities;
using static Inlämningsuppgift_1.Services.ProductService;

namespace Inlämningsuppgift_1.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product? GetById(int id);
        List<Product> Search(string? query, decimal? maxPrice);
        Product Create(string name, decimal price, int stock);
        bool ChangeStock(int id, int delta);
        void UpdateProduct(Product p);
    }
}
