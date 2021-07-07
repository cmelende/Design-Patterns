namespace Command.Receiver
{
    public class Account
    {
        public Account(string ownerName, decimal balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }

        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
    }
}