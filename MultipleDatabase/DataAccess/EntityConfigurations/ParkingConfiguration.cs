using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleDatabase.DTOs;

namespace MultipleDatabase.DataAccess.EntityConfigurations
{
    public class ParkingConfiguration : IEntityTypeConfiguration<ParkingDTO>
    {
        public void Configure(EntityTypeBuilder<ParkingDTO> builder)
        {
            builder.ToTable("Table_Parking");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).ValueGeneratedOnAdd();
        }
    }
}
