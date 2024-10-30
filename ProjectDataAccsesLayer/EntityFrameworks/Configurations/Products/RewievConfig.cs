using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDataAccsesLayer.EntityFrameworks.Configurations.Common;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.EntityFrameworks.Configurations.Products;

public class RewievConfig: BaseConfiguration<Rewiev>
{
    public override void Configure(EntityTypeBuilder<Rewiev> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.Rating).IsRequired();
        builder.Property(x => x.Comment).IsRequired()
            .HasColumnType("nText");

        builder.HasOne(r => r.Customer)
            .WithMany(c => c.Rewievs)
            .HasForeignKey(r => r.CustomerId);

        builder.HasOne(r => r.Product)
            .WithMany(p => p.Rewievs)
            .HasForeignKey(r => r.ProductId);
    }
}
