using System;
using DesignPatternBase;
using FlyweightPattern.Flyweight;
using FlyweightPattern.FlyweightFactory;

namespace FlyweightPattern
{
    public class FlyweightShapeClient : IDesignPatternClient
    {
        public string Name => "Shape Flyweight Example";

        public void Main()
        {
            var sof = ShapeObjectFactory.Instance;

            IShape shape = sof.GetShape("Rectangle");
            shape.Print(ConsoleColor.White);
            shape = sof.GetShape("Rectangle");
            shape.Print(ConsoleColor.Blue);
            shape = sof.GetShape("Rectangle");
            shape.Print(ConsoleColor.Cyan);

            shape = sof.GetShape("Circle");
            shape.Print(ConsoleColor.DarkBlue);
            shape = sof.GetShape("Circle");
            shape.Print(ConsoleColor.DarkMagenta);
            shape = sof.GetShape("Circle");
            shape.Print(ConsoleColor.White);

            int numObjects = sof.TotalObjectsCreated;
            Console.WriteLine("\nTotal No of Objects created = {0}", numObjects);
        }
    }
}