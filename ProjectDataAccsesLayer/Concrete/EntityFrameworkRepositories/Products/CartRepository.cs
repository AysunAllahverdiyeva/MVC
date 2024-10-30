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

public class CartRepository : GenericRepository<Cart>, ICartRepository
{
    public CartRepository(FootWearContext context) : base(context)
    {
    }
}
