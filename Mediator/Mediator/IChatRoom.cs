using Mediator.Colleagues;

namespace Mediator.Mediator
{
    public interface IChatRoom
    {
        void Register(Participant participant);
        void Send(string from, string to, string message);
    }
}