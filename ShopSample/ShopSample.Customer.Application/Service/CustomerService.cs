using ShopSample.Customer.Application.Contracts.Dtos;
using ShopSample.Customer.Application.Contracts.IService;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ShopSample.Customer.Application.Service
{
    public class CustomerService : ApplicationService, ICustomerService
    {
        private readonly IRepository<Domain.Entity.Customer> _customerRepository;

        public CustomerService(IRepository<Domain.Entity.Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerDto> CreateCustomer(CustomerDto dto)
        {
            var entity = ObjectMapper.Map<CustomerDto, Domain.Entity.Customer>(dto);

            var result = await _customerRepository.InsertAsync(entity);

            return ObjectMapper.Map<Domain.Entity.Customer, CustomerDto>(result);
        }

        public async Task<WalletDto> CreateWallet(long customerId, List<WalletDto> wallet)
        {

        }

        public async Task<List<CustomerDto>> GetListAsync()
        {
            try
            {
                var customerList = await _customerRepository.GetListAsync();

                return ObjectMapper.Map<List<Domain.Entity.Customer>, List<CustomerDto>>(customerList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
