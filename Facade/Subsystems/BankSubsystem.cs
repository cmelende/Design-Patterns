using System;

namespace Facade.Subsystems
{
    public class BankSubsystem
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}