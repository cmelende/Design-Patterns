using System;
using VisitorPattern.ConcreteElement;
using VisitorPattern.Visitor;

namespace VisitorPattern.ConcreteVisitor
{
    public class PdfExportVisitor : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine($"{element.ExclusiveMethodOfConcreteComponentA()} + written to pdf");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine($"{element.SpecialMethodOfConcreteComponentB()} + written to pdf");
        }
    }
}