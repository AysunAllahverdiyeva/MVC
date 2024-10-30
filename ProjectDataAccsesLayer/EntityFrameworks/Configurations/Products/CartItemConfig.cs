using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDataAccsesLayer.EntityFrameworks.Configurations.Common;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.EntityFrameworks.Configurations.Products;

public class CartItemConfig:BaseConfiguration<CartItem>
{
    public override void Configure(EntityTypeBuilder<CartItem> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.Quantity).IsRequired();
        builder.Property(x=>x.Price).IsRequired();

        builder.HasOne(ci => ci.Cart)
            .WithMany(c => c.CartItems)
            .HasForeignKey(ci => ci.CartId);

        builder.HasOne(ci => ci.Product)
            .WithMany(p => p.CartItems)
            .HasForeignKey(ci => ci.ProductId);
    }
}

