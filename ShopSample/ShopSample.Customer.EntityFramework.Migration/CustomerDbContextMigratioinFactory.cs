using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ShopSample.Customer.EntityFramework.Migration
{
    public class CustomerDbContextMigratioinFactory : IDesignTimeDbContextFactory<CustomerDbMigratioinContext>
    {
        public CustomerDbMigratioinContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var connectionString = configuration.GetConnectionString("Default");

            var build = new DbContextOptionsBuilder<CustomerDbMigratioinContext>()
                .UseMySql(ServerVersion.AutoDetect(connectionString));

            return new CustomerDbMigratioinContext(build.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var build = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return build.Build();
        }
    }
}
