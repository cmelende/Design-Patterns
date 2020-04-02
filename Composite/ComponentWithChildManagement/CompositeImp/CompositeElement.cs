using System;
using System.Collections.Generic;
using CompositePattern.ComponentWithChildManagement.ComponentImp;

namespace CompositePattern.ComponentWithChildManagement.CompositeImp
{
    public class CompositeElement : DrawingElement

    {
        private readonly List<DrawingElement> _elements = new List<DrawingElement>();


        public CompositeElement(string name) : base(name) { }

        public override void Add(DrawingElement d)
        {
            _elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            _elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine($"{new string('-', indent)} + {Name}");
            foreach (DrawingElement d in _elements)
                d.Display(indent + 2);
        }

        public override CompositeElement GetComposite()
        {
            return this;
        }
    }
}