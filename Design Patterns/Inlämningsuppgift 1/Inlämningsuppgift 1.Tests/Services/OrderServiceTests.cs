using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Services;
using Inlämningsuppgift_1.Tests.Stub_Fake;

namespace Inlämningsuppgift_1.Tests.Services
{
    public class OrderServiceTests
    {
        [Fact]
        public void CreateOrder_ReturnsOrder()
        {
            var fakeOrders = new FakeOrderRepository();
            var fakeCarts = new FakeCartRepository();
            var uow = new StubUnitOfWork(fakeOrders, fakeCarts);

            var service = new OrderService(uow);

            var items = new List<CartItem>
            {
                new CartItem { ProductId = 1, Quantity = 2, UnitPrice = 5m }
            };

            var order = service.CreateOrder(3, items, 10m);

            Assert.NotNull(order);
            Assert.Equal(3, order.UserId);
            Assert.Equal(10m, order.Total);

            Assert.Single(fakeOrders.Stored);
            Assert.Equal(3, fakeOrders.Stored[0].UserId);

            Assert.Equal(3, fakeCarts.ClearedUser);
        }


        [Fact]
        public void Get_ReturnsOrder()
        {
            var expected = new Order { Id = 5, UserId = 9 };

            var stubOrders = new StubOrderRepository { OrderToReturn = expected };
            var uow = new StubUnitOfWork(stubOrders, new StubCartRepository());

            var service = new OrderService(uow);

            var result = service.Get(5);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetForUser_ReturnsCorrectOrders()
        {
            var data = new List<Order>
            {
                new Order { Id = 1, UserId = 2 },
                new Order { Id = 2, UserId = 2 }
            };

            var stubOrders = new StubOrderRepository { OrdersToReturn = data };
            var uow = new StubUnitOfWork(stubOrders, new StubCartRepository());

            var service = new OrderService(uow);

            var result = service.GetForUser(2);

            Assert.Equal(2, ((List<Order>)result).Count);
        }
    }
}
