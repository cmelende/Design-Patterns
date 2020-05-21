using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
    public interface ISubject
    {
        void Attach(IObserver investor);

        void Detach(IObserver investor);

        void Notify();

    }
}
