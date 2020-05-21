namespace ObserverPattern
{
    public class StockInfo
    {
        public string CompanyName { get; }
        public decimal Price { get; }

        public StockInfo(string companyName, decimal price)
        {
            CompanyName = companyName;
            Price = price;
        }
    }
}
