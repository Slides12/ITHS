using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MSSqlAPI.Models;

namespace MSSqlAPI;

public class SqlServerDBContext : DbContext
{

    public SqlServerDBContext(DbContextOptions<SqlServerDBContext> options) : base(options)
    {
    }

    public DbSet<MSSqlAPI.Models.Product> Product { get; set; } = default!;

}
