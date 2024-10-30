using ProjectBusinessLogic.Dtos;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Abstract
{
    public interface ICartServices
    {
        Task<IEnumerable<CartDto>> GetAllOrdersAsync();
        Task<CartDto> GetOrderByIdAsync(int id);
        Task AddOrderAsync(CartDto cartDto);
        Task Remove(int id);
    }
}
