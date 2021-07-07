using System;
using PrototypePattern.Prototype;

namespace PrototypePattern.ConcretePrototype
{
    internal class Color : IColorPrototype
    {
        private readonly int _blue;
        private readonly int _green;
        private readonly int _red;

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        // Create a shallow copy

        public IColorPrototype Clone()
        {
            Console.WriteLine(
                "Cloning color RGB: {0,3},{1,3},{2,3}",
                _red, _green, _blue);

            return MemberwiseClone() as IColorPrototype;
        }
    }
}