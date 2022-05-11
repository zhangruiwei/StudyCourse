using Volo.Abp.Domain.Entities;

namespace ShopSample.Customer.Domain.Entity
{
    public class Customer : AggregateRoot<Guid>
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
