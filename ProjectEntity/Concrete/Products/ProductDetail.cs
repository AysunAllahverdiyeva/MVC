using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Products;

public class ProductDetail: BaseEntity
{
    public decimal Weigh { get; set; }
    public string Material { get; set; }=string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public string Dimension { get; set; }= string.Empty;
    public int ProductId { get; set; }
    public Product Product { get; set; } = new Product();
}
