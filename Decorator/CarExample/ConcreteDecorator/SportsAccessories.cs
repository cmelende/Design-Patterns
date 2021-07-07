using DecoratorPattern.CarExample.Component;
using DecoratorPattern.CarExample.Decorator;

namespace DecoratorPattern.CarExample.ConcreteDecorator
{
    /// <summary>
    ///     Concrete Decorator
    /// </summary>
    public class SportsAccessories : CarAccessoriesDecorator
    {
        public SportsAccessories(ICar aCar) : base(aCar)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Sports Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 15000.0;
        }
    }
}