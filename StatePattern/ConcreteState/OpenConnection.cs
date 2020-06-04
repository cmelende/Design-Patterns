using System;
using StatePattern.State;

namespace StatePattern.ConcreteState
{
    public class OpenConnection : ConnectionState
    {
        public override void Close()
        {
            Console.WriteLine("Closing Connection");
            _context.TransitionTo(new ClosedConnection());
        }

        public override void Open()
        {
            Console.WriteLine("Connection already opened");
            //dont change state, current state still valid
        }
    }
}
