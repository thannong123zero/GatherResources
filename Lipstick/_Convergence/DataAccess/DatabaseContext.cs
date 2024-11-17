using Lipstick._Convergence.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Lipstick._Convergence.DataAccess
{
    public class DatabaseContext : DbContext
    {
        //private readonly IConfiguration _configuration;
        //private readonly string _connectionString;
        public DbSet<MenuGroupDTO> MenuGroups { get; set; }
        public DbSet<MenuItemDTO> MenuItems { get; set; }
        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<UnitDTO> Units { get; set; }
        public DbSet<TopicDTO> Topics { get; set; }
        public DbSet<BrandDTO> Brands { get; set; }
        public DbSet<ArticleDTO> Articles { get; set; }
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
