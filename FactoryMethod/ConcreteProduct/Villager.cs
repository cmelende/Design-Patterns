using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Villager : IPerson
    {
        public string GetName()
        {
            return "Village Person";
        }
    }
}