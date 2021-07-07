using System;
using FacadePattern.Subsystems.Implementation;

namespace FacadePattern.Facade
{
    public class MortgageFacade
    {
        private readonly BankBankSubsystem _bankBankSubsystem = new BankBankSubsystem();
        private readonly CreditSubsystem _creditSubsystem = new CreditSubsystem();
        private readonly LoanSubsystem _loanSubsystem = new LoanSubsystem();

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