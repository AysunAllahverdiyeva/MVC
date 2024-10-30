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

public class ContactConfig:BaseConfiguration<Contact>
{
    public override void Configure(EntityTypeBuilder<Contact> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.Message).IsRequired()
            .HasColumnType("nText");
        builder.Property(x=>x.Subject).IsRequired();

        builder.HasOne(c => c.Customer)
            .WithMany(c => c.Contacts)
            .HasForeignKey(c => c.CustomerId);
    }
}
