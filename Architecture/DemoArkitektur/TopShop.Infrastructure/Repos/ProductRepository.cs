using TopShop.Domain.Entities;
using TopShop.Infrastructure.Interfaces;

namespace TopShop.Infrastructure.Repos
{
    public class ProductRepository : IProductRepo
    {
        private readonly TopShopContext _context;

        public ProductRepository(TopShopContext context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();   
        }
    }
}
