using CompositePattern.ComponentWithoutChildManagement.ComponentImp;

namespace CompositePattern.ComponentWithoutChildManagement.CompositeImp
{
    public interface IComposite : IComponent
    {
        void Add(IComponent comp);
        void Remove(IComponent comp);
    }
}