using System;
using Mediator.ConcreteMediator;

namespace Mediator.Colleagues
{
    public class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public ChatRoom ChatRoom { set; get; }

        public void Send(string to, string message)
        {
            ChatRoom.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{@from} to {Name}: '{message}'");
        }
    }
}