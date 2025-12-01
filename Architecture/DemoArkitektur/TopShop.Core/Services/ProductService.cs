using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShop.Core.Interfaces;
using TopShop.Domain.Entities;
using TopShop.Infrastructure.Interfaces;

namespace TopShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public List<Product> GetProducts()
        {
            return _productRepo.GetProducts();
        }
    }
}
