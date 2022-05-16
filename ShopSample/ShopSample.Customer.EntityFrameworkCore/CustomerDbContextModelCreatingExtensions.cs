using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ShopSample.Customer.EntityFrameworkCore
{
    public static class CustomerDbContextModelCreatingExtensions
    {
        public static void ConfigureCustomerStore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Domain.Entity.Customer>(c =>
            {
                c.ToTable("Customer");
                c.ConfigureByConvention();
            });
        }
    }
}
