using Command.Command;
using Command.Receiver;

namespace Command.ConcreteCommand
{
    public class Transfer : ITransaction
    {
        private readonly decimal _amount;
        private readonly Account _fromAccount;
        private readonly Account _toAccount;

        public Transfer(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;

            IsCompleted = false;
        }

        public bool IsCompleted { get; set; }

        public void Execute()
        {
            if (_fromAccount.Balance >= _amount)
            {
                _fromAccount.Balance -= _amount;
                _toAccount.Balance += _amount;

                IsCompleted = true;
            }
        }
    }
}