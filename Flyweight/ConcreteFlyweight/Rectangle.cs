using System;
using FlyweightPattern.Flyweight;

namespace FlyweightPattern.ConcreteFlyweight
{
    /// <summary>
    ///     A 'ConcreteFlyweight' class
    /// </summary>
    public class Rectangle : IShape
    {
        public void Print(ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine("------------------------------");
            Console.WriteLine("-                            -");
            Console.WriteLine("-                            -");
            Console.WriteLine("-                            -");
            Console.WriteLine("-                            -");
            Console.WriteLine("-                            -");
            Console.WriteLine("-                            -");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
        }
    }
}