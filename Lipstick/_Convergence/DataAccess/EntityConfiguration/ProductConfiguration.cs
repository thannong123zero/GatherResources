﻿using Lipstick._Convergence.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lipstick._Convergence.DataAccess.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductDTO>
    {
        public void Configure(EntityTypeBuilder<ProductDTO> builder)
        {
            builder.ToTable("Table_Products");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.NameEN).IsRequired().HasMaxLength(100);
            builder.Property(s => s.NameVN).IsRequired().HasMaxLength(100);
            //builder.Property(s => s.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            //builder.Property(s => s.ModifiedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.IsActive).HasDefaultValue(false);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
            builder.Property(s => s.InHomePage).HasDefaultValue(false);
            builder.Property(s => s.Price).IsRequired();
            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.Price).IsRequired();
            //builder.HasOne(s => s.Unit).WithMany(g => g.Products).HasForeignKey(s => s.UnitId).IsRequired();
            //builder.HasOne(s => s.MenuItem).WithMany(g => g.Products).HasForeignKey(s => s.MenuItemId).IsRequired();
            //builder.HasOne(s => s.Brand).WithMany(g => g.Products).HasForeignKey(s => s.BrandId).IsRequired(false);
        }
    }
}
