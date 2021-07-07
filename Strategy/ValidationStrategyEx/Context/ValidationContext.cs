using Strategy.ValidationStrategyEx.Models;
using Strategy.ValidationStrategyEx.Strategy;

namespace Strategy.ValidationStrategyEx.Context
{
    public class ValidationContext
    {
        private IValidationStrategy _validation;

        public ValidationContext(IValidationStrategy validation)
        {
            _validation = validation;
        }

        public Validation Validate(object obj, Validation verification)
        {
            return _validation.Validate(obj, verification);
        }

        public void SetValidation(IValidationStrategy validation)
        {
            _validation = validation;
        }
    }
}