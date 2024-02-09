using API.DTO;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace API.ContextObject
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DatabaseContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

    }
}
