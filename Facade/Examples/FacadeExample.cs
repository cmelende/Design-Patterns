using System;
using DesignPatternBase;
using Facade.Facade;

namespace Facade.Examples
{
    public class FacadeExample : IDesignPatternClient
    {
        public string Name => "Financial Facade";

        public void Main()
        {
            var mortgage = new MortgageFacade();

            var customer = new Customer("Ann McKinsey");
            var eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine($"\n{customer.Name} has been {(eligible ? "Approved" : "Rejected")}");

        }
    }
}