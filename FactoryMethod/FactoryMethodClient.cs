using System;
using DesignPatternBase;
using FactoryMethod.Factory;
using static System.Int32;

namespace FactoryMethod
{
    public class FactoryMethodClient : IDesignPatternClient
    {
        public string Name => "PersonFactory Method";
        public void Main()
        {
            Console.WriteLine("Please enter the type of person you wish to create\n" +
                              $"Enter {(int)PersonType.Rural} for {PersonType.Rural.ToString()} and " +
                              $"{(int)PersonType.Urban} for {PersonType.Urban.ToString()}");

            var validInput = TryParse(Console.ReadLine(), out var input);

            if (!validInput)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            var personInput = (PersonType) (input);

            var factory = new PersonFactory();
            var person = factory.GetPerson(personInput);

            Console.WriteLine($"Name: {person.GetName()}");
        }
    }
}