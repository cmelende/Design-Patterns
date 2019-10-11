using Decorator.MarineArenaExample.Component;

namespace Decorator.MarineArenaExample.ConcreteComponent
{
    public class Grunt : IMarine
    {
        public int GetDamage()
        {
            return 5;
        }

        public int GetArmor()
        {
            return 10; 
        }
    }
}