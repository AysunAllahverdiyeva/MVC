using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Products;

public class Contact:BaseEntity
{
    public string Subject { get; set; }=string.Empty;
    public string Message { get; set; }= string.Empty;
    public DateTime ContactDate { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = new Customer();
}
