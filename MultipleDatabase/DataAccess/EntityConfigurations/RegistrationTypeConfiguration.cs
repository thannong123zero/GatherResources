using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleDatabase.DTOs;

namespace MultipleDatabase.DataAccess.EntityConfigurations
{
    public class RegistrationTypeConfiguration : IEntityTypeConfiguration<RegistrationTypeDTO>
    {
        public void Configure(EntityTypeBuilder<RegistrationTypeDTO> builder)
        {
            builder.ToTable("Table_RegistrationType");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).ValueGeneratedOnAdd();
            builder.HasData([
                new RegistrationTypeDTO { ID = 1, NameEN = "Member", NameVN = "Thành Viên" },
                new RegistrationTypeDTO { ID = 2, NameEN = "Member", NameVN = "Thành Viên" },
                new RegistrationTypeDTO { ID = 3, NameEN = "Visitor", NameVN = "Khách Vãng Lai" }
                ]);
        }
    }
}
