using MediatorPattern.Colleagues;

namespace MediatorPattern.Mediator
{
    public interface IChatRoom
    {
        void Register(Participant participant);
        void Send(string from, string to, string message);
    }
}