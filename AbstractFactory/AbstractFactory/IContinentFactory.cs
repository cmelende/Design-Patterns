using AbstractFactory.AbstractProduct;
using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    public interface IContinentFactory
    {
        ICarnivore CreateCarnivore();
        IHerbivore CreateHerbivore();
    }
}