using System;
using DesignPatternBase;
using Mediator.Colleagues;
using Mediator.ConcreteMediator;

namespace Mediator
{
    public class MediatorExampleClient : IDesignPatternClient
    {
        public string Name => "Mediator Example";
        public void Main()
        {

            var chatRoom = new ChatRoom();

            Participant george = new Beatle("George");
            Participant paul = new Beatle("Paul");
            Participant ringo = new Beatle("Ringo");
            Participant john = new Beatle("John");
            Participant yoko = new NonBeatle("Yoko");

            chatRoom.Register(george);
            chatRoom.Register(paul);
            chatRoom.Register(ringo);
            chatRoom.Register(john);
            chatRoom.Register(yoko);


            yoko.Send("John", "Hi John!");
            paul.Send("Ringo", "All you need is love");
            ringo.Send("George", "My sweet Lord");
            paul.Send("John", "Can't buy me love");
            john.Send("Yoko", "My sweet love");


            Console.ReadKey();
        }
    }
}