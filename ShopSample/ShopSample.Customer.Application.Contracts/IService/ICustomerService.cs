using ShopSample.Customer.Application.Contracts.Dtos;
using Volo.Abp.Application.Services;

namespace ShopSample.Customer.Application.Contracts.IService
{
    public interface ICustomerService : IApplicationService
    {
        Task<List<CustomerDto>> GetListAsync();
    }
}
