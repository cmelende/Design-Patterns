using Decorator.MarineArenaExample.Component;

namespace Decorator.MarineArenaExample.ConcreteDecorator
{
    public class EliteArmor : MarineDecorator
    {
        public EliteArmor(IMarine marine) : base(marine) { }

        public override int GetArmor()
        {
            return base.GetArmor() + 75;
        }
    }
}