using Decorator.MarineArenaExample.Component;

namespace Decorator.MarineArenaExample.ConcreteComponent
{
    public class General : IMarine
    {
        public int GetDamage()
        {
            return 50;
        }

        public int GetArmor()
        {
            return 65;
        }
    }
}