using ShopSample.Customer.Domain;
using ShopSample.Customer.EntityFramework.Migration;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ShopSample.Customer.Migrator
{
    [DependsOn(typeof(CustomerDomainModule),
        typeof(AbpAutofacModule),
        typeof(CustomerEntityFrameworkDbMigratioinModule))]
    public class CustomerMigratorModule : AbpModule
    {
    }
}
