using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Products;

    public class Customer:BaseEntity
    {
    public string FirstName { get; set; }=string.Empty;
    public string LastName { get; set; }= string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public ICollection<Order> Orders { get; set;} =new HashSet<Order>();
    public ICollection<Rewiev> Rewievs { get; set; } = new HashSet<Rewiev>();
    public ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
    public int CartId { get; set; }
    public Cart Cart { get; set; } = new Cart();
    }

