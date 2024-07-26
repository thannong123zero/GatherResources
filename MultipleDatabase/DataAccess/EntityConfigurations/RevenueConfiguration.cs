using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleDatabase.DTOs;

namespace MultipleDatabase.DataAccess.EntityConfigurations
{
    public class RevenueConfiguration : IEntityTypeConfiguration<RevenueDTO>
    {
        public void Configure(EntityTypeBuilder<RevenueDTO> builder)
        {
            builder.ToTable("Table_Revenue");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).ValueGeneratedOnAdd();
        }
    }
}
