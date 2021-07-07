namespace ObserverPattern
{
    public class StockInfo
    {
        public StockInfo(string companyName, decimal price)
        {
            CompanyName = companyName;
            Price = price;
        }

        public string CompanyName { get; }
        public decimal Price { get; }
    }
}