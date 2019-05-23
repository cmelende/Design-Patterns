namespace FactoryMethod.ConcreteProduct
{
    public class CityPerson : IPerson
    {
        public string GetName()
        {
            return "City Person";
        }
    }
}