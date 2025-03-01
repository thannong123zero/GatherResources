﻿using Lipstick._Convergence.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lipstick._Convergence.DataAccess.EntityConfiguration
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategoryDTO>
    {
        public void Configure(EntityTypeBuilder<SubCategoryDTO> builder)
        {
            builder.ToTable("Table_SubCategories");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.NameEN).IsRequired().HasMaxLength(100);
            builder.Property(s => s.NameVN).IsRequired().HasMaxLength(100);
            builder.Property(s => s.DescriptionEN).IsRequired(false);
            builder.Property(s => s.DescriptionVN).IsRequired(false);
            //builder.Property(s => s.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            //builder.Property(s => s.ModifiedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.IsActive).HasDefaultValue(false);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
            //builder.HasOne(s => s.MenuGroup).WithMany(g => g.MenuItems).HasForeignKey(s => s.MenuGroupId).IsRequired();
        }
    }
}
