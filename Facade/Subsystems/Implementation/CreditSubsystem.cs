using System;
using Facade.Subsystems.Interface;

namespace Facade.Subsystems.Implementation
{
    public class CreditSubsystem : ICreditSubsystem
    {
        public bool IsEligible(Customer c, int amount)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}