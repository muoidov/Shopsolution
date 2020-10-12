using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopp.Data.Entities;
using Shopp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopp.Data.Configurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
