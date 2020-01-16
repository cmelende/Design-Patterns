using System;
using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight
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