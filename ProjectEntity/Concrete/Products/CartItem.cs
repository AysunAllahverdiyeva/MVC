using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Products;

public class CartItem: BaseEntity
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public int CartId { get; set; } 
    public Cart Cart { get; set; } = new Cart();
    public int ProductId { get; set; }
    public Product Product { get; set; } = new Product();

}
