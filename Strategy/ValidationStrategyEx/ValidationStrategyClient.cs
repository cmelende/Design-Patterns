using DesignPatternBase;
using Strategy.ValidationStrategyEx.ConcreteStrategy;
using Strategy.ValidationStrategyEx.Context;
using Strategy.ValidationStrategyEx.Models;

namespace Strategy.ValidationStrategyEx
{
    public class ValidationStrategyClient : IDesignPatternClient
    {
        public string Name => "Validation Strategy Example";

        public void Main()
        {
            var entityToSave = new Entity();
            var context = new ValidationContext(new SaveValidation());

            context.Validate(entityToSave, new Validation());
            context.SetValidation(new UpdateValidation());
            context.Validate(entityToSave, new Validation());
        }
    }
}