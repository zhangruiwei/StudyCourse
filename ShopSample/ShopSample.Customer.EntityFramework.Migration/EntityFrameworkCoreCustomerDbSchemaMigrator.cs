using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopSample.Customer.Domain.Data;
using Volo.Abp.DependencyInjection;

namespace ShopSample.Customer.EntityFramework.Migration
{
    [Dependency(ServiceLifetime.Transient, ReplaceServices = true)]
    [ExposeServices(typeof(ICustomerStoreSchemaMigrator))]
    public class EntityFrameworkCoreCustomerDbSchemaMigrator : ICustomerStoreSchemaMigrator
    {
        private readonly CustomerDbMigratioinContext _dbContext;

        public EntityFrameworkCoreCustomerDbSchemaMigrator(CustomerDbMigratioinContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}
