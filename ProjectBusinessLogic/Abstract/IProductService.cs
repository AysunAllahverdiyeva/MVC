using ProjectBusinessLogic.Dtos;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewDto>> GetAllProduct();
        Task AddProductAsync(ProdactAddDto prodactAddDto);
        Task Remove(int id);
        Task<ProdactAddDto> GetProductByIdAsync(int id);
    }

    
}
