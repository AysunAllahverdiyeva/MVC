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

public class CustomerConfig:BaseConfiguration<Customer>
{
    public override void Configure(EntityTypeBuilder<Customer> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.FirstName).IsRequired()
        .HasColumnName("First_Name");
        builder.Property(x => x.Address).IsRequired();
        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.LastName).IsRequired()
            .HasColumnName("Last_Name");
        builder.Property(x => x.PhoneNumber).IsRequired()
            .HasColumnName("Phone_Number");

       

    }
}
