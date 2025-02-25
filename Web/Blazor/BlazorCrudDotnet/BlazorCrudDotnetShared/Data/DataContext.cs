using BlazorCrudDotnet.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotnet.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Game> Games { get; set; }
    }
}
