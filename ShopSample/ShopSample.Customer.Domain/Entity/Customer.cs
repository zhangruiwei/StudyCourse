﻿using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace ShopSample.Customer.Domain.Entity
{
    public class Customer : AggregateRoot<long>
    {
        public virtual string Name { get; protected set; }

        public virtual int Age { get; protected set; }

        public virtual List<Wallet> Wallet { get; protected set; }

        protected Customer()
        {

        }

        public Customer(long id, string name, int age)
        {
            Check.NotNull(name, nameof(name));

            Id = id;
            Name = name;
            Age = age;
            Wallet = new List<Wallet>();
        }


        public void AddWallet(Wallet wallet)
        {
            if (Wallet == null)
            {
                Wallet = new List<Wallet>();
            }

            Wallet.Add(wallet);
        }

        public void AddWallets(List<Wallet> wallets)
        {
            Wallet.AddRange(wallets);
        }
    }
}
