using Decorator.MarineArenaExample.Component;

namespace Decorator.MarineArenaExample.ConcreteDecorator
{
    public class AdvancedArmor : MarineDecorator
    {
        public AdvancedArmor(IMarine marine) : base(marine) { }

        public override int GetArmor()
        {
            return base.GetArmor() + 15;
        }
    }
}