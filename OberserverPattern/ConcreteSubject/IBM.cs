using System.Collections.Generic;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern.ConcreteSubject
{
    public class IBM : ISubject

    {
        private IList<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(this, new StockInfo("IBM", Price));
            }
        }

        private decimal _price;
        public decimal Price 
        { 
            get
            {
                return _price;
            } 
            set
            {
                _price = value;
                Notify();
            }
        }
    }
}
