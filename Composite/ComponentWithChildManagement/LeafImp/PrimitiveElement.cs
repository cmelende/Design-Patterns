using System;
using CompositePattern.ComponentWithChildManagement.ComponentImp;

namespace CompositePattern.ComponentWithChildManagement.LeafImp
{
    public class PrimitiveElement : DrawingElement

    {
        public PrimitiveElement(string name) : base(name) { }

        public override void Add(DrawingElement c)
        {
            throw new Exception($"{GetType().Name} has no children and cannot add");
        }

        public override void Remove(DrawingElement c)
        {
            throw new Exception($"{GetType().Name} has no children and cannot remove");
        }

        public override void Display(int indent)
        {
            Console.WriteLine($"{new string('-', indent)} {Name}");
        }
    }
}