using Decorator.MarineArenaExample.Component;

namespace Decorator.MarineArenaExample.ConcreteDecorator
{
    public class AdvancedLoadout : MarineDecorator
    {
        public AdvancedLoadout(IMarine marine) : base(marine) { }

        public override int GetDamage()
        {
            return base.GetDamage() + 10;
        }
    }
}