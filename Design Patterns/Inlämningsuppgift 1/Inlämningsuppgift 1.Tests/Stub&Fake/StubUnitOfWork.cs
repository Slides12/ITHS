using Inlämningsuppgift_1.Data.Interfaces;
using Inlämningsuppgift_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1.Tests.Stub_Fake
{
    public class StubUnitOfWork : IUnitOfWork
    {
        public IOrderRepository Orders { get; }
        public ICartRepository Carts { get; }

        public IUserRepository Users => throw new NotImplementedException();

        public IProductRepository Products => throw new NotImplementedException();

        public StubUnitOfWork(IOrderRepository orders, ICartRepository carts)
        {
            Orders = orders;
            Carts = carts;
        }
    }

}
