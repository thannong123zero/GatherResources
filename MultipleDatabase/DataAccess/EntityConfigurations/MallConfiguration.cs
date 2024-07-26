using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleDatabase.DTOs;

namespace MultipleDatabase.DataAccess.EntityConfigurations
{
    public class MallConfiguration : IEntityTypeConfiguration<MallDTO>
    {
        public void Configure(EntityTypeBuilder<MallDTO> builder)
        {
            builder.ToTable("Table_Mall");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).ValueGeneratedOnAdd();
            builder.HasData([
                new MallDTO { ID = 1, NameEN = "Thiso Sala Center",NameVN ="Trung Tâm Thiso Sala"},
                new MallDTO { ID = 2, NameEN = "Thiso Mall Phan Van Tri",NameVN ="Thiso Mall Phan Văn Trị"},
                new MallDTO { ID = 3, NameEN = "Thiso Mall Truong Chinh - Phan Huy Ich",NameVN ="Thiso Mall Trường Chinh - Phan Huy Ích"},
                ]);
        }
    }
}
