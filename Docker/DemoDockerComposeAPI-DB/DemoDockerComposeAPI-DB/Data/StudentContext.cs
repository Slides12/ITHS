using DemoDockerComposeAPI_DB.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoDockerComposeAPI_DB.Data
{
    public class StudentContext : DbContext
    {

        public StudentContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Student> Students { get; set; }
        }
}
