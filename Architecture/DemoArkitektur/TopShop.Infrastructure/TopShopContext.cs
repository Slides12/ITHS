using Microsoft.EntityFrameworkCore;
using TopShop.Domain.Entities;

namespace TopShop.Infrastructure
{
    public class TopShopContext : DbContext
    {
        public TopShopContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
