using Composite.ComponentWithChildManagement.Leaf;
using CompositePattern.ComponentWithChildManagement.CompositeImp;
using DesignPatternBase;

namespace CompositePattern.ComponentWithChildManagement
{
    public class CompositeWithChildManagementClient : IDesignPatternClient
    {
        public string Name => "Composite with Default Child Management";

        public void Main()
        {
            // Create a tree structure 

            var root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch

            var compositeElement = new CompositeElement("Two Circles");
            compositeElement.Add(new PrimitiveElement("Black Circle"));
            compositeElement.Add(new PrimitiveElement("White Circle"));
            root.Add(compositeElement);

            // Add and remove a PrimitiveElement

            var primitive = new PrimitiveElement("Yellow Line");
            root.Add(primitive);
            root.Remove(primitive);

            // Recursively display nodes
            root.Display(1);

            //GetComposite will return null if its a primitive element
            primitive.GetComposite()?.Add(new PrimitiveElement("Black Line"));
        }
    }
}

