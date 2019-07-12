using System;
using FactoryMethod.ConcreteProduct;
using FactoryMethod.Product;

namespace FactoryMethod.Factory
{
    /// <summary>
    /// Implementation of PersonFactory - Used to create objects
    /// </summary>
    public class PersonFactory
    {
        public IPerson GetPerson(PersonType type)
        {
            switch (type)
            {
                case PersonType.Rural:
                    return new Villager();
                case PersonType.Urban:
                    return new CityPerson();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}