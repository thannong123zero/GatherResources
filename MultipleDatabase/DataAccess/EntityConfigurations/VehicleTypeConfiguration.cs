using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleDatabase.DTOs;

namespace MultipleDatabase.DataAccess.EntityConfigurations
{
    public class VehicleTypeConfiguration : IEntityTypeConfiguration<VehicleTypeDTO>
    {
        public void Configure(EntityTypeBuilder<VehicleTypeDTO> builder)
        {
            builder.ToTable("Table_VehicleType");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).ValueGeneratedOnAdd();
            builder.HasData([
                new VehicleTypeDTO { ID = 1, NameEN = "Car", NameVN = "Ô tô" },
                new VehicleTypeDTO { ID = 2, NameEN = "Motorbike", NameVN = "Xe máy" },
                new VehicleTypeDTO { ID = 3, NameEN = "Bicycle", NameVN = "Xe đạp" }
                ]);
        }
    }
}
