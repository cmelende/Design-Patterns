using System;

namespace Facade.Subsystems
{
    public class CreditSubsystem
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}