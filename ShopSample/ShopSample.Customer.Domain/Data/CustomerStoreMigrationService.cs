using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.DependencyInjection;

namespace ShopSample.Customer.Domain.Data
{
    public class CustomerStoreMigrationService : ITransientDependency
    {
        public ILogger<CustomerStoreMigrationService> _logger { get; set; }
        private readonly ICustomerStoreSchemaMigrator _migrate;

        public CustomerStoreMigrationService(ICustomerStoreSchemaMigrator migrate)
        {
            _migrate = migrate;

            _logger = NullLogger<CustomerStoreMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            _logger.LogInformation("Stared");

            await _migrate.MigrateAsync();

            _logger.LogInformation("Completed");
        }
    }
}
