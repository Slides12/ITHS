using Inlämningsuppgift_1.Data.Interfaces;
using Inlämningsuppgift_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1.Data.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Users { get; }
        public IProductRepository Products { get; }
        public IOrderRepository Orders { get; }
        public ICartRepository Carts { get; }

        public UnitOfWork(
            IUserRepository users,
            IProductRepository products,
            IOrderRepository orders,
            ICartRepository carts)
        {
            Users = users;
            Products = products;
            Orders = orders;
            Carts = carts;
        }
    }
}
