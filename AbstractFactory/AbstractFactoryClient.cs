using AbstractFactory.AbstractFactory;
using AbstractFactory.Client;
using AbstractFactory.ConcreteFactory;
using DesignPatternBase;

namespace AbstractFactory
{
    public class AbstractFactoryClient : IDesignPatternClient
    {
        public string Name => "Abstract Factory";

        public void Main()
        {
            // Create and run the African animal world
            IContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            IContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }
    }
}