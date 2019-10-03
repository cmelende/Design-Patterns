using System.Collections.Generic;
using CompositePattern.ComponentWithoutChildManagement.ComponentImp;
using CompositePattern.ComponentWithoutChildManagement.CompositeImp;
using CompositePattern.ComponentWithoutChildManagement.LeafImp;
using DesignPatternBase;

namespace CompositePattern.ComponentWithoutChildManagement
{
    public class CompositeNoChildManagementClient : IDesignPatternClient
    {
        public string Name => "Composite without Child Management";
        public void Main()
        {
            // Create a tree structure 

            var root = new CompositeClass();
            root.Add(new Leaf());
            root.Add(new Leaf());
            root.Add(new Leaf());

            // Create a branch

            var compositeElement = new CompositeClass();
            compositeElement.Add(new Leaf());
            compositeElement.Add(new Leaf());
            root.Add(compositeElement);

            // Add and remove a PrimitiveElement

            var primitive = new Leaf();
            root.Add(primitive);
            root.Remove(primitive);

            //Say we have a collection of these
            var components = new List<IComponent> {root, compositeElement, primitive};

            //We lost some uniformity, so we have to type check
            foreach (var component in components)
            {
                if (component is IComposite)
                    (component as IComposite).Add(new Leaf());
            }

            root.Write();
        }
    }
}