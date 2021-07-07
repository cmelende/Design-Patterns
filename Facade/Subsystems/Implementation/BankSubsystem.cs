using System;
using FacadePattern.Subsystems.Interface;

namespace FacadePattern.Subsystems.Implementation
{
    public class BankBankSubsystem : IBankSubsystem
    {
        public bool IsEligible(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}