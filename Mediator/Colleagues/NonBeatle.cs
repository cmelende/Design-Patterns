using System;

namespace Mediator.Colleagues
{
    public class NonBeatle : Participant
    {
        public NonBeatle(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
