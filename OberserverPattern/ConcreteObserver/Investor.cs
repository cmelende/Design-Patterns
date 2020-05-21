using System;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern.ConcreteObserver
{
    public class Investor : IObserver

    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(ISubject subject, StockInfo info)
        {
            Console.WriteLine($"{_name} is being notified by {info.CompanyName} that its stock is now {info.Price}");
        }

        public ISubject Subject { get; set; }
    }
}
