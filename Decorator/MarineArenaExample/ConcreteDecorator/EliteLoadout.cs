using Decorator.MarineArenaExample.Component;
using DecoratorPattern.MarineArenaExample.Decorator;

namespace DecoratorPattern.MarineArenaExample.ConcreteDecorator
{
    public class EliteLoadout : MarineDecorator
    {
        public EliteLoadout(IMarine marine) : base(marine)
        {
        }

        public override int GetDamage()
        {
            return base.GetDamage() + 100;
        }
    }
}