using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L006_ModelConfiguration.Model;

internal class DemoContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = new SqlConnectionStringBuilder()
        {
            ServerSPN = "localhost",
            InitialCatalog = "DemoDB",
            TrustServerCertificate = true,
            IntegratedSecurity = true,
        }.ToString();

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().ToTable("IthsStudents", "ITHS").HasKey(s => new {s.FirstName, s.LastName});

        modelBuilder.Entity<Student>().Ignore(s => s.MyProperty);

        modelBuilder.Entity<Student>().Property(s => s.DateOfBirth).HasColumnName("Birtday");

        modelBuilder.Entity<Student>().Property<String>("ShadowData");
    }
}


[Table("MyStudents", Schema = "ITHS")]
public class Student
{
    public int StudentId { get; set; }

    [NotMapped]
    public int MyProperty { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    [Column("BirthDate")]
    public DateOnly? DateOfBirth { get; set; }
}