using System;
using DesignPatternBase;
using Facade.Facade;
using Facade.Subsystems.Implementation;

namespace Facade.Examples
{
    public class DiFacadeExample : IDesignPatternClient
    {
        public string Name => "Dependency Injection Facade";
        public void Main()
        {
            //There can be multiple implementations of each interface
            var mortgage = new DiMortgageFacade(new BankBankSubsystem(), new CreditSubsystem(), new LoanSubsystem());

            var customer = new Customer("Ann McKinsey");
            var eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine($"\n{customer.Name} has been {(eligible ? "Approved" : "Rejected")}");
        }
    }
}