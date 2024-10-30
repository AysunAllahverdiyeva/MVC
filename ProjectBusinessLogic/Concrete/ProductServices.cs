using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectBusinessLogic.Abstract;
using ProjectBusinessLogic.Dtos;
using ProjectDataAccsesLayer.Abstract.Products;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Concrete
{
    public class ProductServices : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductServices(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task AddProductAsync(ProdactAddDto prodactAddDto)
        {
            var product = new Product
            {
                Name = prodactAddDto.Name,
                Description = prodactAddDto.Description,
                Price = prodactAddDto.Price,
                CategoryId = prodactAddDto.CategoryId
            };

            _productRepository.AddAsync(product);
            await _productRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductViewDto>> GetAllProduct()
        {
            var productList=await _productRepository.GetAllAsync();
            var productViewDtos=_mapper.Map<IEnumerable<ProductViewDto>>(productList);   
            return productViewDtos;
        }

        public async Task<ProdactAddDto> GetProductByIdAsync(int id)
        {
            var product=await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProdactAddDto>(product);
        }

        public async Task Remove(int id)
        {
            var deleteproduct = await _productRepository.GetByIdAsync(id);
            if (deleteproduct is null)
            {
                throw new Exception("Product can not found!");
            }
            _productRepository.Remove(deleteproduct);
            await _productRepository.SaveChangesAsync();
        }
    }
}
