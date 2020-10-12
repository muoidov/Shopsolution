using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopp.Data.Configurations
{
   public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new {t.CategoryId, t.ProductId});   
            builder.ToTable("ProductInCategories");
            builder.HasOne(pt =>pt.Product).WithMany(p => p.ProductInCategories).HasForeignKey(pt => pt.ProductId);
            builder.HasOne(pt =>pt.Category).WithMany(p => p.ProductInCategories).HasForeignKey(pt => pt.CategoryId);
        }
    }
}
