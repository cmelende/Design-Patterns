using System;
using System.Collections.Generic;
using FactoryMethod.ConcreteProduct;

namespace FactoryMethod.Factory
{
    public class PersonProviderFactory
    {
        private readonly IDictionary<PersonType, Func<IPerson>> _providers = new Dictionary<PersonType, Func<IPerson>>
        {
            {PersonType.Rural, () => new Villager() },
            {PersonType.Urban, () => new CityPerson() }
        };

        public IPerson Get(PersonType type)
        {
            var person = _providers[type];
            if (person == null)
            {
                throw new Exception($"Person implementation not found for type {type}");
            }

            return person();
        }

        public void Register(PersonType type, Func<IPerson> person)
        {
            if (_providers[type] != null)
            {
                throw new Exception($"Person implemenation already exists for type {type}");
            }

            _providers.Add(type, person);
        }
    }
}