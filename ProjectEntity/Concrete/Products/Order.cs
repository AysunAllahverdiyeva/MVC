using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Products;

    public class Order:BaseEntity
    {
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = new Customer();
    public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    
    }

