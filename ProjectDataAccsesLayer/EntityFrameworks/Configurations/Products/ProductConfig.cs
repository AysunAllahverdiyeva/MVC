using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using ProjectDataAccsesLayer.EntityFrameworks.Configurations.Common;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.EntityFrameworks.Configurations.Products;

public class ProductConfig:BaseConfiguration<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);
        builder.Property(x=>x.Price).IsRequired();
        builder.Property(x => x.Color).IsRequired();
        builder.Property(x => x.Description).IsRequired()
            .HasColumnType("nText");
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Size).IsRequired();
        builder.Property(x => x.Weigh).IsRequired();

        builder.HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);

    }
}
