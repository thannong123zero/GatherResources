using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleDatabase.DTOs;

namespace MultipleDatabase.DataAccess.EntityConfigurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<VoucherDTO>
    {
        public void Configure(EntityTypeBuilder<VoucherDTO> builder)
        {
            builder.ToTable("Table_Voucher");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).ValueGeneratedOnAdd();
        }
    }
}
