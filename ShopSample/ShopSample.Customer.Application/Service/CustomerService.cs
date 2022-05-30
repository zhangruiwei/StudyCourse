using ShopSample.Customer.Application.Contracts.Dtos;
using ShopSample.Customer.Application.Contracts.IService;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace ShopSample.Customer.Application.Service
{
    public class CustomerService : ApplicationService, ICustomerService
    {
        private readonly IRepository<Domain.Entity.Customer> _customerRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public CustomerService(IRepository<Domain.Entity.Customer> customerRepository,
            IUnitOfWorkManager unitOfWorkManager)
        {
            _customerRepository = customerRepository;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task<CustomerDto> CreateCustomer(CustomerDto dto)
        {
            var entity = ObjectMapper.Map<CustomerDto, Domain.Entity.Customer>(dto);

            var result = await _customerRepository.InsertAsync(entity);

            return ObjectMapper.Map<Domain.Entity.Customer, CustomerDto>(result);
        }

        public async Task<WalletDto> CreateWallet(long customerId, WalletDto wallet)
        {
            var customer = await _customerRepository.FirstOrDefaultAsync(c => c.Id == customerId);

            if (customer == null)
            {
                return null;
            }

            var entity = ObjectMapper.Map<WalletDto, Domain.Entity.Wallet>(wallet);

            customer.AddWallet(entity);

            using (var uow = _unitOfWorkManager.Begin())
            {
                await _customerRepository.UpdateAsync(customer, false);

                await uow.CompleteAsync();

                return ObjectMapper.Map<Domain.Entity.Wallet, WalletDto>(entity);
            }
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
