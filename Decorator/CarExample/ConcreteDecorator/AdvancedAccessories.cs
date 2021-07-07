using DecoratorPattern.CarExample.Component;
using DecoratorPattern.CarExample.Decorator;

namespace DecoratorPattern.CarExample.ConcreteDecorator
{
    /// <summary>
    ///     Concrete Decorator
    /// </summary>
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICar aCar) : base(aCar)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Advanced Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 10000.0;
        }
    }
}