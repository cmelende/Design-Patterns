using System;
using FacadePattern.Subsystems.Interface;

namespace FacadePattern.Subsystems.Implementation
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