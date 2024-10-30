using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.Abstract.Products;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IEnumerable<Product>> GetProducts();
}
