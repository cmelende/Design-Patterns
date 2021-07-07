using CompositePattern.ComponentWithChildManagement.CompositeImp;

namespace CompositePattern.ComponentWithChildManagement.ComponentImp
{
    public abstract class DrawingElement

    {
        protected string Name;

        public DrawingElement(string name)
        {
            Name = name;
        }

        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);

        public virtual CompositeElement GetComposite()
        {
            return null;
        }
    }
}