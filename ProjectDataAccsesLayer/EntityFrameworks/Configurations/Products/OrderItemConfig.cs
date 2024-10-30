using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDataAccsesLayer.EntityFrameworks.Configurations.Common;
using ProjectEntity.Concrete.Common;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.EntityFrameworks.Configurations.Products;

public class OrderItemConfig:BaseConfiguration<OrderItem>
{
    public override void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.Quantity).IsRequired();
        builder.Property(x=>x.Price).IsRequired();

        builder.HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId);

        builder.HasOne(oi => oi.Product)
            .WithMany(p => p.OrderItems)
            .HasForeignKey(oi => oi.ProductId);
    }
}
