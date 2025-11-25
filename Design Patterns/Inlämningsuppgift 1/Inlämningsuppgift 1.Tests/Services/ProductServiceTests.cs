using Inlämningsuppgift_1.Data.Data;
using Inlämningsuppgift_1.Data.Repository;
using Inlämningsuppgift_1.Repository;
using Inlämningsuppgift_1.Services;

namespace Inlämningsuppgift_1.Tests.Services
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetAll_ReturnsAllProducts()
        {
            // Arrange
            var userRepo = new UserRepository();
            var productRepo = new ProductRepository();
            var orderRepo = new OrderRepository();
            var cartRepo = new CartRepository();

            var repo = new UnitOfWork(userRepo,productRepo,orderRepo,cartRepo);

            var service = new ProductService(repo);

            // Act
            var result = service.GetAll();

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Count >= 0);
        }

        [Fact]
        public void GetById_ReturnsNull_WhenNotFound()
        {
            // Arrange
            var userRepo = new UserRepository();
            var productRepo = new ProductRepository();
            var orderRepo = new OrderRepository();
            var cartRepo = new CartRepository();

            var repo = new UnitOfWork(userRepo, productRepo, orderRepo, cartRepo);

            var service = new ProductService(repo);

            // Act
            var result = service.GetById(9999);

            // Assert
            Assert.Null(result);
        }



        [Fact]
        public void ChangeStock_UpdatesStock_WhenProductExists()
        {
            // Arrange
            var userRepo = new UserRepository();
            var productRepo = new ProductRepository();
            var orderRepo = new OrderRepository();
            var cartRepo = new CartRepository();

            var repo = new UnitOfWork(userRepo, productRepo, orderRepo, cartRepo);

            var service = new ProductService(repo);
            var p = service.Create("X", 2m, 2);

            // Act
            var ok = service.ChangeStock(p.Id, 5);

            // Assert
            Assert.True(ok);
            var updated = service.GetById(p.Id);
            Assert.Equal(7, updated.Stock);
        }
       
    }
}
