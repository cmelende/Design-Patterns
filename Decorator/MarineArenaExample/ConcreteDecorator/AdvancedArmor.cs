using Decorator.MarineArenaExample.Component;
using DecoratorPattern.MarineArenaExample.Decorator;

namespace DecoratorPattern.MarineArenaExample.ConcreteDecorator
{
    public class AdvancedArmor : MarineDecorator
    {
        public AdvancedArmor(IMarine marine) : base(marine)
        {
        }

        public override int GetArmor()
        {
            return base.GetArmor() + 15;
        }
    }
}