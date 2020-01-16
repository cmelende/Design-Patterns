using System.Collections.Generic;
using Flyweight.ConcreteFlyweight;
using Flyweight.Flyweight;

namespace Flyweight.FlyweightFactory
{
    /// <summary>
    ///     The 'FlyweightFactory' class
    /// </summary>
    public class ShapeObjectFactory
    {
        private ShapeObjectFactory()
        {
            //Note: this can happen on startup, or initializing some canvas for drawing shapes
            Shapes = new Dictionary<string, IShape>
            {
                {"Rectangle", new Rectangle()},
                { "Circle", new Circle()}
            };

        }

        public static ShapeObjectFactory Instance = new ShapeObjectFactory();

        public readonly Dictionary<string, IShape> Shapes; 

        public int TotalObjectsCreated => Shapes.Count;

        public IShape GetShape(string shapeName)
        {
            if (Shapes.ContainsKey(shapeName))
                return Shapes[shapeName];
            
            throw new KeyNotFoundException("Invalid shape key");
        }
    }
}