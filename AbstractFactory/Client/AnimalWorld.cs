using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.Client
{
    public class AnimalWorld

    {
        private readonly ICarnivore _carnivore;
        private readonly IHerbivore _herbivore;

        public AnimalWorld(IContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}