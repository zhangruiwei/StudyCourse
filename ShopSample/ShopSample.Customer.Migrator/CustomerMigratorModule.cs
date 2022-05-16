using ShopSample.Customer.Domain;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ShopSample.Customer.Migrator
{
    [DependsOn(typeof(CustomerDomainModule),
        typeof(AbpAutofacModule))]
    public class CustomerMigratorModule : AbpModule
    {
    }
}
