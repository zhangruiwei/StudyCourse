namespace ShopSample.Customer.Domain.Data
{
    public interface ICustomerStoreSchemaMigrator
    {
        Task MigrateAsync();
    }
}
