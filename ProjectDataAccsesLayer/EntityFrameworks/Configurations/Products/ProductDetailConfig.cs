using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDataAccsesLayer.EntityFrameworks.Configurations.Common;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.EntityFrameworks.Configurations.Products;

public class ProductDetailConfig:BaseConfiguration<ProductDetail>
{
    public override void Configure(EntityTypeBuilder<ProductDetail> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.Material).IsRequired();
        builder.Property(x=>x.Manufacturer).IsRequired();
        builder.Property(x => x.Dimension).IsRequired();
        builder.Property(x => x.Weigh).IsRequired();

        builder.HasOne(pd => pd.Product)
            .WithOne(p => p.ProductDetail)
            .HasForeignKey<ProductDetail>(pd => pd.ProductId);

    }
}
