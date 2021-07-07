using System;
using StatePattern.State;

namespace StatePattern.ConcreteState
{
    public class ClosedConnection : ConnectionState
    {
        public override void Close()
        {
            Console.WriteLine("Connection already closed!");
        }

        public override void Open()
        {
            Console.WriteLine("Opening connection");
            _context.TransitionTo(new OpenConnection());
        }
    }
}