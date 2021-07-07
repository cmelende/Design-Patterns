using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class CityPerson : IPerson
    {
        public string GetName()
        {
            return "City Person";
        }
    }
}