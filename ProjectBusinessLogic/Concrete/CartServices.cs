using AutoMapper;
using ProjectBusinessLogic.Abstract;
using ProjectBusinessLogic.Dtos;
using ProjectDataAccsesLayer.Abstract.Products;
using ProjectDataAccsesLayer.Concrete.EntityFrameworkRepositories.Products;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Concrete
{
    public class CartServices : ICartServices
    {
        private readonly CartRepository _cartRepository;
        private readonly IMapper _mapper;

        public CartServices(CartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        public async Task AddOrderAsync(CartDto cartDto)
        {
            var cart = new Cart   
            {
                Id = cartDto.Id,
                CustomerId = cartDto.CustomerId
               
            };

            _cartRepository.AddAsync(cart);
            await _cartRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<CartDto>> GetAllOrdersAsync()
        {
            var cartList = await _cartRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CartDto>>(cartList);
        }

        public async Task<CartDto> GetOrderByIdAsync(int id)
        {
            var cart = await _cartRepository.GetByIdAsync(id);
            return _mapper.Map<CartDto>(cart);
        }

        public async Task Remove(int id)
        {
            var deleteCart = await _cartRepository.GetByIdAsync(id);
            _cartRepository.Remove(deleteCart);
            await _cartRepository.SaveChangesAsync();
        }
    }
}
