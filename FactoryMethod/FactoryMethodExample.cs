using System;
using DesignPatternBase;
using FactoryMethod.Factory;

namespace FactoryMethod
{
    public class FactoryMethodExample : IDesignPatternClient
    {
        public string Name => "PersonFactory Method";
        public void Main()
        {
            Console.WriteLine("Please enter the type of person you wish to create");
            var input = (PersonType)Console.Read();

            var factory = new PersonFactory();
            var person = factory.GetPerson(input);

            Console.WriteLine($"Name: {person.GetName()}");
        }
    }
}