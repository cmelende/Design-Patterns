using VisitorPattern.Visitor;

namespace VisitorPattern.Element
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}