using ProjectBusinessLogic.Dtos;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Abstract
{
    public interface IRewievServices
    {
        Task<IEnumerable<RewievDto>> GetAllRewievsAsync();
        Task<RewievDto> GetReByIdAsync(int id);
        Task AddRewievAsync(RewievDto rewievDto);
        Task Remove(int id);
        Task UpdateProductAsync(RewievDto rewievDto);
       
    }
}
