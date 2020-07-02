using System;
using Strategy.ValidationStrategyEx.Models;

namespace Strategy.ValidationStrategyEx.ConcreteStrategy
{
    public class CommonValidation 
    {
        public Validation SomeCommonValidation(object obj, Validation verification)
        {
            Console.WriteLine("Running common validation");
            verification.AddError("myProp", "my update/save error");
            return verification;
        }
    }
}