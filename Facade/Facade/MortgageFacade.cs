using System;
using Facade.Subsystems;

namespace Facade.Facade
{
    public class MortgageFacade
    {
        private readonly BankSubsystem _bankSubsystem = new BankSubsystem();
        private readonly CreditSubsystem _creditSubsystem = new CreditSubsystem();
        private readonly LoanSubsystem _loanSubsystem = new LoanSubsystem();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                customer.Name, amount);

            var eligible = true;

            if (!_bankSubsystem.HasSufficientSavings(customer, amount))
                eligible = false;
            else if (!_loanSubsystem.HasNoBadLoans(customer))
                eligible = false;
            else if (!_creditSubsystem.HasGoodCredit(customer)) eligible = false;

            return eligible;
        }
    }
}