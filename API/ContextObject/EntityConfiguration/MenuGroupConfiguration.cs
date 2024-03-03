using API.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.ContextObject.EntityConfiguration
{
    public class MenuGroupConfiguration : IEntityTypeConfiguration<MenuGroup>
    {
        public void Configure(EntityTypeBuilder<MenuGroup> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.NameEN).IsRequired().HasMaxLength(225);
            builder.Property(s => s.NameVN).IsRequired().HasMaxLength(225);
            builder.Property(s => s.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.ModifiedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.IsActive).HasDefaultValue(false);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
        }
    }
}
