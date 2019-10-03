using System;
using CompositePattern.ComponentWithoutChildManagement.ComponentImp;

namespace CompositePattern.ComponentWithoutChildManagement.LeafImp
{
    public class Leaf : IComponent
    {
        public void Write()
        {
            Console.WriteLine("I am a leaf!");
        }
    }
}