﻿using Lipstick._Convergence.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lipstick._Convergence.DataAccess.EntityConfiguration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.NameEN).IsRequired().HasMaxLength(225);
            builder.Property(s => s.NameVN).IsRequired().HasMaxLength(225);
            builder.Property(s => s.DescriptionEN).IsRequired(false);
            builder.Property(s => s.DescriptionVN).IsRequired(false);
            builder.Property(s => s.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.ModifiedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.IsActive).HasDefaultValue(false);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
        }
    }
}
