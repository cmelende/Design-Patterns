using Decorator.MarineArenaExample.Component;

namespace Decorator.MarineArenaExample.ConcreteDecorator
{
    public class EliteLoadout : MarineDecorator
    {
        public EliteLoadout(IMarine marine) : base(marine) { }

        public override int GetDamage()
        {
            return base.GetDamage() + 100;
        }
    }
}