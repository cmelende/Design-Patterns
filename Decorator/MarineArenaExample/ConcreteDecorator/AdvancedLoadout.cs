using Decorator.MarineArenaExample.Component;
using DecoratorPattern.MarineArenaExample.Decorator;

namespace DecoratorPattern.MarineArenaExample.ConcreteDecorator
{
    public class AdvancedLoadout : MarineDecorator
    {
        public AdvancedLoadout(IMarine marine) : base(marine)
        {
        }

        public override int GetDamage()
        {
            return base.GetDamage() + 10;
        }
    }
}