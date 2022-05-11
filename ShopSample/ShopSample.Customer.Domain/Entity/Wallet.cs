using Volo.Abp.Domain.Entities;

namespace ShopSample.Customer.Domain.Entity
{
    public class Wallet : Entity<Guid>
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
    }
}
