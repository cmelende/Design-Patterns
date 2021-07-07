using DesignPatternBase;
using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubject;

namespace ObserverPattern
{
    public class ObserverClient : IDesignPatternClient
    {
        public string Name => "Observer example";

        public void Main()
        {
            var ibm = new IBM();
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            ibm.Price = 120.10m;
            ibm.Price = 121.00m;
            ibm.Price = 120.50m;
            ibm.Price = 120.75m;
        }
    }
}