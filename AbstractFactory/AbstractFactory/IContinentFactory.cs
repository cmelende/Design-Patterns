using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    public interface IContinentFactory
    {
        ICarnivore CreateCarnivore();
        IHerbivore CreateHerbivore();
    }
}