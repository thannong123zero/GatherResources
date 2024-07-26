using Microsoft.EntityFrameworkCore;
using MultipleDatabase.DTOs;
using System.Reflection;

namespace MultipleDatabase.DataAccess
{
    public class ApplicationDatabaseContext : DbContext
    {
        public DbSet<MallDTO> Malls { get; set; }
        public DbSet<ParkingDTO> Parkings { get; set; }
        public DbSet<ParkingHistoryDTO> ParkingHistorys { get; set; }
        public DbSet<RegistrationTypeDTO> RegistrationTypes { get; set; }
        public DbSet<RevenueDTO> Revenues { get; set; }
        public DbSet<VehicleTypeDTO> Vehicles { get; set; }
        public DbSet<VoucherTypeDTO> VoucherTypes { get; set;}
        public DbSet<VoucherDTO> Vouchers { get; set; }
        public ApplicationDatabaseContext() { }
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
