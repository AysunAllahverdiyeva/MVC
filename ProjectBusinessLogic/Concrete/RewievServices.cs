using AutoMapper;
using ProjectBusinessLogic.Abstract;
using ProjectBusinessLogic.Dtos;
using ProjectDataAccsesLayer.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Concrete
{
    public class RewievServices : IRewievServices
    {
        private readonly IRewievRepository _rewievRepository;
        private readonly IMapper _mapper;
        public RewievServices(IRewievRepository rewievRepository, IMapper mapper)
        {
            _rewievRepository = rewievRepository;
            _mapper = mapper;
        }

        
        public Task AddRewievAsync(RewievDto rewievDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RewievDto>> GetAllRewievsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RewievDto> GetReByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(RewievDto rewievDto)
        {
            throw new NotImplementedException();
        }
    }
}
