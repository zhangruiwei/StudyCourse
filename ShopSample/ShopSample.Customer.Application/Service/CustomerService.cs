using ShopSample.Customer.Application.Contracts;
using ShopSample.Customer.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ShopSample.Customer.Application
{
    public class CustomerService : ApplicationService, ICustomerService
    {
        /*
        private readonly IRepository<Domain.Entity.Customer> _customerRepository;

        public CustomerService(IRepository<Domain.Entity.Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<CustomerDto>> GetListAsync()
        {
            var customerList = await _customerRepository.GetListAsync();

            return ObjectMapper.Map<List<Domain.Entity.Customer>, List<CustomerDto>>(customerList);
        }

        */
        public async Task<List<CustomerDto>> GetListAsync()
        {
            return await Task.FromResult(new List<CustomerDto>
            {
                 new CustomerDto
                 {
                     Name = "张三",
                      Age= 18,
                       Wallet = new List<WalletDto>
                       {
                          new WalletDto {
                             Name ="微信",
                              Money =100
                          }
                       }
                 }
            });
        }
    }
}
