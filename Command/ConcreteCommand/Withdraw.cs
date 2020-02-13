﻿using Command.Command;
using Command.Receiver;

namespace Command.ConcreteCommand
{
    public class Withdraw : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public bool IsCompleted { get; set; }

        public Withdraw(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;

            IsCompleted = false;
        }

        public void Execute()
        {
            if (_account.Balance >= _amount)
            {
                _account.Balance -= _amount;

                IsCompleted = true;
            }
        }
    }
}
