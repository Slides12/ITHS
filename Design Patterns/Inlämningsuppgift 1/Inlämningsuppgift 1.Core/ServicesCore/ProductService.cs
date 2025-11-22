using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Interfaces;

namespace Inlämningsuppgift_1.Services
{
    public class ProductService : IProductService
    {
        //2
        //private static readonly List<Product> Products = new List<Product>
        //{
        //    new Product { Id = 1, Name = "Pen", Price = 1.5m, Stock = 100 },
        //    new Product { Id = 2, Name = "Notebook", Price = 3.0m, Stock = 50 },
        //    new Product { Id = 3, Name = "Mug", Price = 6.0m, Stock = 20 }
        //};
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //3
        //public class Product
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; } = "";
        //    public decimal Price { get; set; }
        //    public int Stock { get; set; }
        //}

        public List<Product> GetAll() => /*Products*/ _productRepository.GetAll();

        public Product? GetById(int id) => /*Products.FirstOrDefault(p => p.Id == id)*/ _productRepository.GetById(id);

        //1
        public List<Product> Search(string? query, decimal? maxPrice)
        {
            //if (string.IsNullOrWhiteSpace(query)) return Products.ToList();
            //var q = query!.ToLowerInvariant();

            //return Products.Where(p => p.Name.ToLowerInvariant().Contains(q) || p.Price.ToString().Contains(q)).ToList();

            IEnumerable<Product> results = _productRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(query))
            {
                var q = query!.ToLowerInvariant();
                results = results.Where(p =>
                    p.Name.ToLowerInvariant().Contains(q) ||
                    p.Price.ToString().Contains(q)
                );
            }

            if (maxPrice.HasValue)
                results = results.Where(p => p.Price <= maxPrice.Value);

            return results.ToList();
        }

        public Product Create(string name, decimal price, int stock)
        {
            var products = _productRepository.GetAll();
            var newId = products.Any() ? products.Max(p => p.Id) + 1 : 1;
            var p = new Product { Id = newId, Name = name, Price = price, Stock = stock };
            _productRepository.Create(p);
            return p;
        }

        public bool ChangeStock(int id, int delta)
        {
            var p = GetById(id);
            if (p == null) return false;
            p.Stock += delta;
            return true;
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
