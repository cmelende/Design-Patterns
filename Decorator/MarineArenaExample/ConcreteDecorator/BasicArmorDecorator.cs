using Decorator.MarineArenaExample.Component;
using DecoratorPattern.MarineArenaExample.Decorator;

namespace DecoratorPattern.MarineArenaExample.ConcreteDecorator
{
    public class BasicArmorDecorator : MarineDecorator
    {
        public BasicArmorDecorator(IMarine marine) : base(marine)
        {
        }

        public override int GetArmor()
        {
            return base.GetArmor() + 5;
        }
    }
}