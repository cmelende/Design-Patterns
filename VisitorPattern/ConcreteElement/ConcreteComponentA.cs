using VisitorPattern.Element;
using VisitorPattern.Visitor;

namespace VisitorPattern.ConcreteElement
{
    public class ConcreteComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}