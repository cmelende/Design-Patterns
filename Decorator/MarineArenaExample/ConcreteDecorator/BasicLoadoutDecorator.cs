using Decorator.MarineArenaExample.Component;
using DecoratorPattern.MarineArenaExample.Decorator;

namespace DecoratorPattern.MarineArenaExample.ConcreteDecorator
{
    public class BasicLoadoutDecorator : MarineDecorator
    {
        public BasicLoadoutDecorator(IMarine marine) : base(marine)
        {
        }

        public override int GetDamage()
        {
            return base.GetDamage() + 5;
        }
    }
}