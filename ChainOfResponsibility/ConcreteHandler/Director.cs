using System;
using ChainOfResponsibility.Details;
using ChainOfResponsibility.Handler;

namespace ChainOfResponsibilityPattern.ConcreteHandler
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
                Console.WriteLine($"{GetType().Name} approved request# {purchase.Number}");
            else
                Successor?.ProcessRequest(purchase);
        }
    }
}