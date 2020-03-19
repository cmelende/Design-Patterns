using System;
using DesignPatternBase;
using IteratorPattern.ConcreteAggregate;

namespace IteratorPattern
{
    public class IteratorDesignPattern : IDesignPatternClient
    {
        public string Name => "Iterator example";

        public void Main()
        {
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (object element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (object element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}