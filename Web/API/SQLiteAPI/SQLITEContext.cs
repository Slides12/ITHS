

using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using My_API;
using System.Xml;

public class SQLITEContext : DbContext 
{
    public DbSet<Room> Room { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<Review> Review { get; set; }
    public DbSet<Customers> Customers { get; set; }
    public DbSet<ContactInfo> ContactInfo { get; set; }
    public DbSet<Booking> Booking{ get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = new SqliteConnectionStringBuilder(){
            DataSource = "APIDB.db",
            Cache = SqliteCacheMode.Shared
        }.ToString();
        optionsBuilder.UseSqlite(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>()
            .HasKey(b => b.Id); 

        modelBuilder.Entity<Booking>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd(); 
    }

}