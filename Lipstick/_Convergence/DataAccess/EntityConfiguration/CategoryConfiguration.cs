using Lipstick._Convergence.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lipstick._Convergence.DataAccess.EntityConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<CategoryDTO>
    {
        public void Configure(EntityTypeBuilder<CategoryDTO> builder)
        {
            builder.ToTable("Table_Categories");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.NameEN).IsRequired().HasMaxLength(225);
            builder.Property(s => s.NameVN).IsRequired().HasMaxLength(225);
            builder.Property(s => s.DescriptionEN).IsRequired(false);
            builder.Property(s => s.DescriptionVN).IsRequired(false);
            //builder.Property(s => s.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            //builder.Property(s => s.ModifiedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.IsActive).HasDefaultValue(false);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
            builder.Property(s => s.InNavbar).HasDefaultValue(false);
            builder.Property(s => s.Priority).HasDefaultValue(0);
        }
    }
}
