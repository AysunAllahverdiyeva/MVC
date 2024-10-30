using Microsoft.EntityFrameworkCore;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.EntityFrameworks.Context;

public class FootWearContext: DbContext
{

    public FootWearContext(DbContextOptions<FootWearContext> options) : base(options)
    {
        
    }



    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductDetail> ProductDetails { get; set; }
    public DbSet<Rewiev> Rewievs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Category>().
            HasData(
            new Category { Id = 1, CategoryName = "Sneakers" },
            new Category { Id = 2, CategoryName = "Loafer" },
            new Category { Id = 3, CategoryName = "Sandal" },
            new Category { Id = 4, CategoryName = "Boot" },
            new Category { Id = 5, CategoryName = "Heels" }
            );
    }

}
