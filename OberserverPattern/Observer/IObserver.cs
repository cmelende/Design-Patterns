using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    public interface IObserver

    {
        void Update(ISubject stock, StockInfo info);
    }
}
