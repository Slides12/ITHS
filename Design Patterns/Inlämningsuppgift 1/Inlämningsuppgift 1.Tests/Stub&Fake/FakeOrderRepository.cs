using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1.Tests.Stub_Fake
{
    public class FakeOrderRepository : IOrderRepository
    {
        public List<Order> Stored = new();

        public Order Get(int id) => Stored.Find(o => o.Id == id);

        public IEnumerable<Order> GetForUser(int userId) =>
            Stored.FindAll(o => o.UserId == userId);

        public void CreateOrder(Order order)
        {
            order.Id = Stored.Count + 1;
            Stored.Add(order);
        }
    }

}
