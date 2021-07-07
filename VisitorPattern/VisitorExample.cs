using System;
using System.Collections.Generic;
using DesignPatternBase;
using VisitorPattern.ConcreteElement;
using VisitorPattern.ConcreteVisitor;
using VisitorPattern.Element;
using VisitorPattern.Visitor;

namespace VisitorPattern
{
    public class Client
    {
        public static void ClientCode(IEnumerable<IComponent> components, IVisitor visitor)
        {
            foreach (IComponent component in components) component.Accept(visitor);
        }
    }

    public class VisitorExample : IDesignPatternClient
    {
        public string Name => "VisitorPattern Example";

        public void Main()
        {
            var components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base VisitorPattern interface:");
            var visitor1 = new XmlExportVisitor();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new PdfExportVisitor();
            Client.ClientCode(components, visitor2);
        }
    }
}