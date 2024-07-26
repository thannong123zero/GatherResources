using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleDatabase.DTOs;

namespace MultipleDatabase.DataAccess.EntityConfigurations
{
    public class VoucherTypeConfiguration : IEntityTypeConfiguration<VoucherTypeDTO>
    {
        public void Configure(EntityTypeBuilder<VoucherTypeDTO> builder)
        {
            builder.ToTable("Table_VoucherType");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).ValueGeneratedOnAdd();
            builder.HasData([
                new VoucherTypeDTO { ID = 1, NameEN = "Emart", NameVN = "Emart" },
                new VoucherTypeDTO { ID = 2, NameEN = "Thisky Hall", NameVN = "Thisky Hall" }
                ]);
        }
    }
}
