using Inlämningsuppgift_1.Data.Data;
using Inlämningsuppgift_1.Data.Repository;
using Inlämningsuppgift_1.Repository;
using Inlämningsuppgift_1.Services;

namespace Inlämningsuppgift_1.Tests.Services
{
    public class CartServiceTests
    {
        [Fact]
        public void AddToCart_AddsNewItemifStockOk()
        {
            // Arrange
            var userRepo = new UserRepository();
            var productRepo = new ProductRepository();
            var orderRepo = new OrderRepository();
            var cartRepo = new CartRepository();

            var repo = new UnitOfWork(userRepo, productRepo, orderRepo, cartRepo);

            var productService = new ProductService(repo);
            var service = new CartService(repo);

            var prod = productService.Create("TestProd", 5.0m, 10);

            // Act
            service.AddToCart(1, prod.Id, 2);

            // Assert
            var cart = cartRepo.GetById(1);
            Assert.NotNull(cart);
            Assert.Single(cart);
            Assert.Equal(prod.Id, cart[0].ProductId);
            Assert.Equal(2, cart[0].Quantity);
        }

        [Fact]
        public void AddToCart_DoesNotAddIfNoProd()
        {
            // Arrange
            var userRepo = new UserRepository();
            var productRepo = new ProductRepository();
            var orderRepo = new OrderRepository();
            var cartRepo = new CartRepository();

            var repo = new UnitOfWork(userRepo, productRepo, orderRepo, cartRepo);

            var productService = new ProductService(repo);
            var service = new CartService(repo);

            // Act
            service.AddToCart(1, 9999, 1);

            // Assert
            var cart = cartRepo.GetById(1);
            Assert.Null(cart);
        }

        [Fact]
        public void AddToCart_DoesNotAddWhenNoStock()
        {
            // Arrange
            var userRepo = new UserRepository();
            var productRepo = new ProductRepository();
            var orderRepo = new OrderRepository();
            var cartRepo = new CartRepository();

            var repo = new UnitOfWork(userRepo, productRepo, orderRepo, cartRepo);

            var productService = new ProductService(repo);
            var service = new CartService(repo);

            var prod = productService.Create("Limited", 2.0m, 1);

            // Act
            service.AddToCart(1, prod.Id, 2);

            // Assert
            var cart = cartRepo.GetById(1);
            Assert.Null(cart);
        }

        [Fact]
        public void AddToCart_IncrementsQuantitySameProduct()
        {
            // Arrange
            var userRepo = new UserRepository();
            var productRepo = new ProductRepository();
            var orderRepo = new OrderRepository();
            var cartRepo = new CartRepository();

            var repo = new UnitOfWork(userRepo, productRepo, orderRepo, cartRepo);

            var productService = new ProductService(repo);
            var service = new CartService(repo);

            var prod = productService.Create("Multi", 3.0m, 10);

            // Act
            service.AddToCart(1, prod.Id, 2);
            service.AddToCart(1, prod.Id, 3);

            // Assert
            var cart = cartRepo.GetById(1);
            Assert.NotNull(cart);
            Assert.Single(cart);
            Assert.Equal(5, cart[0].Quantity);
        }

        [Fact]
        public void GetCartForUser_ReturnsEmptyCart()
        {
            // Arrange
            var userRepo = new UserRepository();
            var productRepo = new ProductRepository();
            var orderRepo = new OrderRepository();
            var cartRepo = new CartRepository();

            var repo = new UnitOfWork(userRepo, productRepo, orderRepo, cartRepo);

            var productService = new ProductService(repo);
            var service = new CartService(repo);

            // Act
            var result = service.GetCartForUser(42);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);

            var stored = cartRepo.GetById(42);
            Assert.NotNull(stored);
        }
    }
}
