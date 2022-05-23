using Microsoft.Extensions.DependencyInjection;
using ShopSample.Customer.Domain.Data;
using ShopSample.Customer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ShopSample.Customer.EntityFramework.Migration
{
    [DependsOn(
        typeof(CustomerEntityFrameworkCoreModule)
        )]
    public class CustomerEntityFrameworkDbMigratioinModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddDbContext<CustomerDbMigratioinContext>();
        }
    }
}
