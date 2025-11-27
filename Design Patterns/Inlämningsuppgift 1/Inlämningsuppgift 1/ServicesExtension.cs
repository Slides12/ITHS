using Inlämningsuppgift_1.Data.Data;
using Inlämningsuppgift_1.Data.Interfaces;
using Inlämningsuppgift_1.Data.Repository;
using Inlämningsuppgift_1.Interfaces;
using Inlämningsuppgift_1.Repository;
using Inlämningsuppgift_1.Services;

namespace Inlämningsuppgift_1
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<ICartService, CartService>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IOrderService, OrderService>();

            services.AddSingleton<ICartRepository, CartRepository>();
            services.AddSingleton<IOrderRepository, OrderRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();

            services.AddSingleton<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
