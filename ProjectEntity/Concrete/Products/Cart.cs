using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Products;

public class Cart:BaseEntity
{
    public ICollection<CartItem> CartItems { get; set; } =new HashSet<CartItem>();
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }= new Customer();
}
