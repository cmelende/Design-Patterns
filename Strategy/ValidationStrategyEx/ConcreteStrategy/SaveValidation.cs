using System;
using Strategy.ValidationStrategyEx.Models;
using Strategy.ValidationStrategyEx.Strategy;

namespace Strategy.ValidationStrategyEx.ConcreteStrategy
{
    public class SaveValidation : CommonValidation, IValidationStrategy
    {
        public Validation Validate(object obj, Validation verification)
        {
            Console.WriteLine("Running validation for saving a new entity");
            verification.AddError("myProp", "my save new error");
            SomeCommonValidation(obj, verification);
            return verification;
        }
    }
}