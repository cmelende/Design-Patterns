using System;
using DesignPatternBase;
using FactoryMethodPattern.Factory;
using FactoryMethodPattern.Product;
using static System.Int32;

namespace FactoryMethodPattern
{
    public class FactoryMethodClient : IDesignPatternClient
    {
        public string Name => "PersonFactory Method";

        public void Main()
        {
            Console.WriteLine("Please enter the type of person you wish to create\n" +
                              $"Enter {(int) PersonType.Rural} for {PersonType.Rural.ToString()} and " +
                              $"{(int) PersonType.Urban} for {PersonType.Urban.ToString()}");

            bool validInput = TryParse(Console.ReadLine(), out int input);

            if (!validInput)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            var personInput = (PersonType) input;

            var factory = new PersonFactory();
            IPerson person = factory.GetPerson(personInput);

            Console.WriteLine($"Name: {person.GetName()}");
        }
    }
}