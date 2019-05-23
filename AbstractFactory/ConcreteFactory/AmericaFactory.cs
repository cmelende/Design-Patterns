using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory
{
    public class AmericaFactory : IContinentFactory

    {
        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}