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
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerServices(ICustomerRepository customerRepository , IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task AddCustomerAsync(CustomerDto customerDto)
        {

            var customer = new Customer
            {
               FirstName = customerDto.FirstName,
               LastName = customerDto.LastName,
               Email = customerDto.Email,
               Address = customerDto.Address,
               PhoneNumber = customerDto.PhoneNumber
            };

            _customerRepository.AddAsync(customer);
            await _customerRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomersAsync()
        {
            var customerList = await _customerRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CustomerDto>>(customerList);
        }

        public async Task<CustomerDto> GetCustomerByIdAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task Remove(int id)
        {

            var deleteCustomer = await _customerRepository.GetByIdAsync(id);
            _customerRepository.Remove(deleteCustomer);
            await _customerRepository.SaveChangesAsync();
        }

     
    }
}
