using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Client
{
    public class AnimalWorld

    {
        private readonly IHerbivore _herbivore;
        private readonly ICarnivore _carnivore;

        // Constructor
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