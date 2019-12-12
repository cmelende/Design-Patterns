using System;
using Facade.Subsystems.Interface;

namespace Facade.Subsystems.Implementation
{
    public class LoanSubsystem : ILoadSubsystem
    {
        public bool IsEligible(Customer c, int amount)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}