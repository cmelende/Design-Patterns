using System;
using Command.ConcreteCommand;
using Command.Invoker;
using Command.Receiver;
using DesignPatternBase;

namespace CommandPattern
{
    public class CommandClient : IDesignPatternClient
    {
        public string Name => "Command Example";

        public void Main()
        {
            //Invoker
            var transactionQueue = new TransactionQueue();

            //Receiver
            var suesAccount = new Account("Sue Smith", 0);

            //Commands
            var suesDeposit = new Deposit(suesAccount, 100);
            var suesWithdrawal = new Withdraw(suesAccount, 50);

            //Receiver
            var corysAccount = new Account("Cory Melendez", 100);

            //Commands
            var corysDeposit = new Deposit(corysAccount, 50);
            var corysWithdrawal = new Withdraw(corysAccount, 40);

            //Adding to queue to be executed, first in first out
            transactionQueue.AddTransaction(suesDeposit);
            transactionQueue.AddTransaction(corysDeposit);
            transactionQueue.AddTransaction(suesWithdrawal);
            transactionQueue.AddTransaction(corysWithdrawal);

            transactionQueue.ProcessPendingTransactions();

            Console.WriteLine($"Cory's balance: {corysAccount.Balance}");
            Console.WriteLine($"Sue's balance: {suesAccount.Balance}");
        }
    }
}