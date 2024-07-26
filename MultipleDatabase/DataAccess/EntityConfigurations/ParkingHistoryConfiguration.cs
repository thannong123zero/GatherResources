using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleDatabase.DTOs;

namespace MultipleDatabase.DataAccess.EntityConfigurations
{
    public class ParkingHistoryConfiguration : IEntityTypeConfiguration<ParkingHistoryDTO>
    {
        public void Configure(EntityTypeBuilder<ParkingHistoryDTO> builder)
        {
            builder.ToTable("Table_ParkingHistory");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).ValueGeneratedOnAdd();
        }
    }
}
