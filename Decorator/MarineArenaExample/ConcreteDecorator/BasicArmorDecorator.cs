using Decorator.MarineArenaExample.Component;

namespace Decorator.MarineArenaExample.ConcreteDecorator
{
    public class BasicArmorDecorator : MarineDecorator
    {
        public BasicArmorDecorator(IMarine marine) : base(marine) { }

        public override int GetArmor()
        {
            return base.GetArmor() + 5;
        }
    }
}