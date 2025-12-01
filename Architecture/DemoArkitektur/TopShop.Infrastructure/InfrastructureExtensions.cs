using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TopShop.Infrastructure.Interfaces;
using TopShop.Infrastructure.Repos;

namespace TopShop.Infrastructure
{
    public static class InfrastructureExtensions
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connString = configuration.GetConnectionString("TopShopConn");

            services.AddDbContext<TopShopContext>(options =>
            {
                options.UseSqlServer(connString);
            });


            services.AddScoped<IProductRepo, ProductRepository>();

            return services;
        }
    }
}
