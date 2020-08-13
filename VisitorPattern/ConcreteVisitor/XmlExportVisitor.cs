using System;
using VisitorPattern.ConcreteElement;
using VisitorPattern.Visitor;

namespace VisitorPattern.ConcreteVisitor
{
    public class XmlExportVisitor : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + written to xml");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + written to xml");
        }
    }
}