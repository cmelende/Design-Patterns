using System;
using Strategy.ValidationStrategyEx.Models;
using Strategy.ValidationStrategyEx.Strategy;

namespace Strategy.ValidationStrategyEx.ConcreteStrategy
{
    public class UpdateValidation : CommonValidation, IValidationStrategy
    {
        public Validation Validate(object obj, Validation verification)
        {
            Console.WriteLine("Running validation for updating");
            verification.AddError("myProp", "my update error");
            SomeCommonValidation(obj, verification);
            return verification;
        }
    }
}