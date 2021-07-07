using System;
using System.Collections;
using System.Collections.Generic;
using DesignPatternBase;
using IteratorPattern.ConcreteAggregate;

namespace IteratorPattern
{
    public class IteratorDesignPattern : IDesignPatternClient
    {
        public string Name => "Iterator example";

        public void Main()
        {
            var collection = new Collection();
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);

            Console.WriteLine("Straight traversal:");

            foreach (object element in collection) Console.WriteLine(element);
        }

        public void Main2()
        {
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (object element in collection) Console.WriteLine(element);

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (object element in collection) Console.WriteLine(element);
        }
    }

    public class Collection
    {
        private readonly IList<int> Numbers;

        public Collection()
        {
            Numbers = new List<int>();
        }

        public IList<int> GetItems()
        {
            return Numbers;
        }

        public IEnumerator GetEnumerator()
        {
            return new Enum(this);
        }

        public void Add(int n)
        {
            Numbers.Add(n);
        }
    }

    public class Enum : IEnumerator
    {
        private readonly Collection _collection;

        // Stores the current traversal position. An iterator may have a lot of
        // other fields for storing iteration state, especially when it is
        // supposed to work with a particular kind of collection.
        private int _position = -1;

        private readonly bool _reverse;

        public Enum(Collection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse) _position = collection.GetItems().Count;
        }

        public bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }

        object IEnumerator.Current => Current();

        public object Current()
        {
            return _collection.GetItems()[_position];
        }

        public int Key()
        {
            return _position;
        }
    }
}