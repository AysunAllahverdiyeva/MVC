using ProjectDataAccsesLayer.Abstract.Products;
using ProjectDataAccsesLayer.Concrete.EntityFrameworkRepositories.Commons;
using ProjectDataAccsesLayer.EntityFrameworks.Context;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.Concrete.EntityFrameworkRepositories.Products;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(FootWearContext context) : base(context)
    {
    }
}
