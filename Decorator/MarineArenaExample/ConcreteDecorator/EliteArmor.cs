using Decorator.MarineArenaExample.Component;
using DecoratorPattern.MarineArenaExample.Decorator;

namespace DecoratorPattern.MarineArenaExample.ConcreteDecorator
{
    public class EliteArmor : MarineDecorator
    {
        public EliteArmor(IMarine marine) : base(marine)
        {
        }

        public override int GetArmor()
        {
            return base.GetArmor() + 75;
        }
    }
}