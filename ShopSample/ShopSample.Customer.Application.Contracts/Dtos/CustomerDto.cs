namespace ShopSample.Customer.Application.Contracts.Dtos
{
    public class CustomerDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public List<WalletDto> Wallet { get; set; }
    }

    public class WalletDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Money { get; set; }
    }

}
