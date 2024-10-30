using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Products;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Color { get; set; } = string.Empty;
    public string Size { get; set; } = string.Empty;
    public decimal Weigh { get; set; }
    public int ProductDetailId { get; set; }
    public ProductDetail ProductDetail { get; set; } = new ProductDetail();
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new Category();
    public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    public ICollection<Rewiev> Rewievs { get; set; } = new HashSet<Rewiev>();
    public ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
}