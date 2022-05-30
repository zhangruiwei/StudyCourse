using ShopSample.Customer.Application.Contracts.Dtos;
using Volo.Abp.Application.Services;

namespace ShopSample.Customer.Application.Contracts.IService
{
    public interface ICustomerService : IApplicationService
    {

        Task<CustomerDto> CreateCustomer(CustomerDto dto);
        Task<List<CustomerDto>> GetListAsync();
        Task<WalletDto> CreateWallet(long customerId, WalletDto wallet);
    }
}
