using System;
using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight
{
    /// <summary>
    ///     A 'ConcreteFlyweight' class
    /// </summary>
    public class Circle : IShape
    {
        public void Print(ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine("    _.-\"\"\"\"-._");
            Console.WriteLine("  .'          `.");
            Console.WriteLine(" /              \\");
            Console.WriteLine("|                |");
            Console.WriteLine("|                |");
            Console.WriteLine("|                |");
            Console.WriteLine(" \\              /");
            Console.WriteLine("  `._        _.'");
            Console.WriteLine("     `-....-'");
            Console.ResetColor();
        }
    }
}