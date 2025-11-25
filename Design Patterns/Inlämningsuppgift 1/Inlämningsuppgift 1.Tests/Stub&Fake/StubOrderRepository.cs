using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1.Tests.Stub_Fake
{
    public class StubOrderRepository : IOrderRepository
    {
        public Order OrderToReturn { get; set; }
        public IEnumerable<Order> OrdersToReturn { get; set; }

        public Order Get(int id) => OrderToReturn;
        public IEnumerable<Order> GetForUser(int userId) => OrdersToReturn;

        public void CreateOrder(Order order) { }
    }

}
