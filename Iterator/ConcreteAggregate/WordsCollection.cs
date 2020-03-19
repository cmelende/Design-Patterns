using System.Collections;
using System.Collections.Generic;
using IteratorPattern.Aggregate;
using IteratorPattern.ConcreteIterator;

namespace IteratorPattern.ConcreteAggregate
{
    public class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> GetItems()
        {
            return _collection;
        }

        public void AddItem(string item)
        {
            _collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}