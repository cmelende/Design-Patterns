using Decorator.MarineArenaExample.Component;

namespace DecoratorPattern.MarineArenaExample.ConcreteComponent
{
    public class Sargent : IMarine
    {
        public int GetDamage()
        {
            return 8;
        }

        public int GetArmor()
        {
            return 13;
        }
    }
}