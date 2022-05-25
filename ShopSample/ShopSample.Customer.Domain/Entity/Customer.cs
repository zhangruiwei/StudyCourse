using System.Collections.ObjectModel;
using Volo.Abp.Domain.Entities;

namespace ShopSample.Customer.Domain.Entity
{
    public class Customer : AggregateRoot<long>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        private List<Wallet> _wallet = new List<Wallet>();

        public List<Wallet> Wallet
        {
            get
            {
                return _wallet;
            }
        }

        public void AddWallet(Wallet wallet)
        { 
            this._wallet.Add(wallet);
        }
    }
}
