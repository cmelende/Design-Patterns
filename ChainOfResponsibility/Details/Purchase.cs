namespace ChainOfResponsibility.Details
{
    public class Purchase
    {
        public Purchase(int number, double amount, string purpose)
        {
            Number = number;
            Amount = amount;
            Purpose = purpose;
        }

        public int Number { get; set; }

        public double Amount { get; set; }

        public string Purpose { get; set; }
    }
}