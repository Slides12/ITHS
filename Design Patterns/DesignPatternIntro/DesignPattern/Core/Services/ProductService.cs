using DesignPattern.Core.Interfaces;
using DesignPattern.Data.Entities;

namespace DesignPattern.Core.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>() { 
            new Product(1, "Samsung"),
            new Product(1, "yo"),
            new Product(1, "mama")

            };

            return products;
        }
    }
}
