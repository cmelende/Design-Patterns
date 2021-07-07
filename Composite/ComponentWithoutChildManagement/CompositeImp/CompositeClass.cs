using System;
using System.Collections.Generic;
using CompositePattern.ComponentWithoutChildManagement.ComponentImp;

namespace CompositePattern.ComponentWithoutChildManagement.CompositeImp
{
    public class CompositeClass : IComposite
    {
        private readonly IList<IComponent> _children = new List<IComponent>();

        public void Write()
        {
            Console.WriteLine("I am a composite!");
            foreach (IComponent component in _children) component.Write();
        }

        public void Add(IComponent comp)
        {
            _children.Add(comp);
        }

        public void Remove(IComponent comp)
        {
            _children.Remove(comp);
        }
    }
}