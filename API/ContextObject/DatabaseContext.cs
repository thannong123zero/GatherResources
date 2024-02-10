using API.DTO;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace API.ContextObject
{
    public class DatabaseContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DatabaseContext() : base()
        {
        }
        public DatabaseContext(IConfiguration configuration) : base()
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
