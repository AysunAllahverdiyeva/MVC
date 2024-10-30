using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Products;

    public class Category:BaseEntity
    {
    public string CategoryName { get; set; }=string.Empty;
    public ICollection<Product> Products { get; set;}=new HashSet<Product>();
    }

