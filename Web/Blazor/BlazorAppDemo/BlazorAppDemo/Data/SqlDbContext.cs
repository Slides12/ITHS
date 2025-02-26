using BlazorAppDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppDemo.Data
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<PersonInfoEntity> Persons { get; set; }
    }
}
