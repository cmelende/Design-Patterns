using Strategy.ValidationStrategyEx.Models;

namespace Strategy.ValidationStrategyEx.Strategy
{
    public interface IValidationStrategy
    {
        Validation Validate(object obj, Validation verification);
    }
}