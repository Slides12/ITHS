using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L013_RepositoryPattern.Model;

internal class MovieContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "mongodb+srv://admin:admin@iths.jrmip.mongodb.net/";
        var collection = "sample_mflix";

        optionsBuilder.UseMongoDB(connectionString, collection);
    }
}
