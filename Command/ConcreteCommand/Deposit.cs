﻿using Command.Command;
using Command.Receiver;

namespace Command.ConcreteCommand
{
    public class Deposit : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public Deposit(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;

            IsCompleted = false;
        }

        public bool IsCompleted { get; set; }

        public void Execute()
        {
            _account.Balance += _amount;

            IsCompleted = true;
        }
    }
}