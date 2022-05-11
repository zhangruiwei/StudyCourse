using Microsoft.Extensions.DependencyInjection;
using ShopSample.Customer.Application.Contracts;
using ShopSample.Customer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace ShopSample.Customer.Application
{
    [DependsOn(
        typeof(CustomerApplicationContractsModule),
        typeof(CustomerDomainModule),
        typeof(AbpAutoMapperModule))]
    public class CustomerApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

            context.Services.AddAutoMapperObjectMapper<CustomerApplicationModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<CustomerApplicationModule>();
            });

        }
    }
}
