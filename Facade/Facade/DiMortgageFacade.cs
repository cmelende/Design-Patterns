using System;
using Facade.Subsystems;
using Facade.Subsystems.Interface;

namespace Facade.Facade
{
    public class DiMortgageFacade
    {
        private readonly IBankSubsystem _bankBankSubsystem; 
        private readonly ICreditSubsystem _creditSubsystem ;
        private readonly ILoadSubsystem _loanSubsystem ;

        public DiMortgageFacade(IBankSubsystem bankBank, ICreditSubsystem credit, ILoadSubsystem loan)
        {
            _bankBankSubsystem = bankBank;
            _creditSubsystem = credit;
            _loanSubsystem = loan;
        }
        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                customer.Name, amount);

            var eligible = true;

            if (!_bankBankSubsystem.IsEligible(customer, amount))
                eligible = false;
            else if (!_loanSubsystem.IsEligible(customer, amount))
                eligible = false;
            else if (!_creditSubsystem.IsEligible(customer, amount)) eligible = false;

            return eligible;
        }
    }
}