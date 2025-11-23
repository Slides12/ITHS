using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Interfaces;

namespace Inlämningsuppgift_1.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Pen", Price = 1.5m, Stock = 100 },
            new Product { Id = 2, Name = "Notebook", Price = 3.0m, Stock = 50 },
            new Product { Id = 3, Name = "Mug", Price = 6.0m, Stock = 20 }
        };

        public void Create(Product product)
        {
            Products.Add(product);
        }

        public List<Product> GetAll()
        {
            return Products.ToList();
        }

        public Product? GetById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateProduct(Product p)
        {
            var existing = GetById(p.Id);
            if (existing == null) return;

            existing.Name = p.Name;
            existing.Price = p.Price;
            existing.Stock = p.Stock;
        }
    }
}
