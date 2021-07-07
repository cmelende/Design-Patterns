using System.Collections.Generic;
using FlyweightPattern.ConcreteFlyweight;
using FlyweightPattern.Flyweight;

namespace FlyweightPattern.FlyweightFactory
{
    /// <summary>
    ///     The 'FlyweightFactory' class
    /// </summary>
    public class ShapeObjectFactory
    {
        public static ShapeObjectFactory Instance = new ShapeObjectFactory();

        public readonly Dictionary<string, IShape> Shapes;

        private ShapeObjectFactory()
        {
            //Note: this can happen on startup, or initializing some canvas for drawing shapes
            Shapes = new Dictionary<string, IShape>
            {
                {"Rectangle", new Rectangle()},
                {"Circle", new Circle()}
            };
        }

        public int TotalObjectsCreated => Shapes.Count;

        public IShape GetShape(string shapeName)
        {
            if (Shapes.ContainsKey(shapeName))
                return Shapes[shapeName];

            throw new KeyNotFoundException("Invalid shape key");
        }
    }
}