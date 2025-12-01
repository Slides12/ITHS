using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShop.Domain.Entities;

namespace TopShop.Core.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
