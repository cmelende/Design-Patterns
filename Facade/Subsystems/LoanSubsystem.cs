using System;

namespace Facade.Subsystems
{
    public class LoanSubsystem
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}