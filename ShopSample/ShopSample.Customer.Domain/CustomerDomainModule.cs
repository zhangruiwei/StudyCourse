using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace ShopSample.Customer.Domain
{
    [DependsOn(typeof(AbpMultiTenancyModule))]
    public class CustomerDomainModule : AbpModule
    {
    }
}
