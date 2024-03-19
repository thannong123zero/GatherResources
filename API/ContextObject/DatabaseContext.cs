using Microsoft.EntityFrameworkCore;
using SharedLibrary.DTO;

namespace API.ContextObject
{
    public class DatabaseContext : DbContext
    {
        //private readonly IConfiguration _configuration;
        //private readonly string _connectionString;
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DatabaseContext()
        {
           
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        //public DatabaseContext(IConfiguration configuration) : base()
        //{
        //    _configuration = configuration;
        //    _connectionString = _configuration.GetConnectionString("SqlConnection");
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_connectionString);
        //}
    }
}
    