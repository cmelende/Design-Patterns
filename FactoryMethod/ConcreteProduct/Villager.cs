using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class Villager : IPerson
    {
        public string GetName()
        {
            return "Village Person";
        }
    }
}