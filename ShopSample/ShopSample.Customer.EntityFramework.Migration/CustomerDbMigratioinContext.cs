using Microsoft.EntityFrameworkCore;
using ShopSample.Customer.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ShopSample.Customer.EntityFramework.Migration
{
    [ConnectionStringName("Default")]
    public class CustomerDbMigratioinContext : AbpDbContext<CustomerDbMigratioinContext>
    {
        public CustomerDbMigratioinContext(DbContextOptions<CustomerDbMigratioinContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureCustomerStore();
        }
    }
}
