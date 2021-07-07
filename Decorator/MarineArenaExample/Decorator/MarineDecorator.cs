using System;
using Decorator.MarineArenaExample.Component;

namespace DecoratorPattern.MarineArenaExample.Decorator
{
    public abstract class MarineDecorator : IMarine
    {
        protected IMarine Marine;

        public MarineDecorator(IMarine marine)
        {
            Marine = marine;
        }

        public virtual int GetDamage()
        {
            return Marine.GetDamage();
        }

        public virtual int GetArmor()
        {
            return Marine.GetArmor();
        }

        public bool Attack(IMarine marine)
        {
            if (GetDamage() > marine.GetArmor()) return true;

            return false;
        }

        public bool Defend(IMarine marine)
        {
            if (GetArmor() >= marine.GetDamage()) return true;

            return false;
        }

        public void PrintStats()
        {
            Console.WriteLine("Stats");
            Console.WriteLine($"Damange: {GetDamage()}");
            Console.WriteLine($"Armor: {GetArmor()}");
        }
    }
}