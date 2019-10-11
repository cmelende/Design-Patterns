using Decorator.MarineArenaExample.Component;

namespace Decorator.MarineArenaExample.ConcreteComponent
{
    public class Captain : IMarine
    {
        public int GetDamage()
        {
            return 12;
        }

        public int GetArmor()
        {
            return 16;
        }
    }
}