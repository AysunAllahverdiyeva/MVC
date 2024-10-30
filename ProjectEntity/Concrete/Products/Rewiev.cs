using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Products;

    public class Rewiev:BaseEntity
    {
    public int Rating { get; set; }
    public string Comment { get; set; }=string.Empty;
    public DateTime RewievDate { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }= new Customer();
    public int ProductId { get; set; }
    public Product Product { get; set; } = new Product();
    }

