using StatePattern.State;

namespace StatePattern.Context
{
    public class Context
    {
        private ConnectionState _state;

        public Context(ConnectionState state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(ConnectionState state)
        {
            //Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Open()
        {
            _state.Open();
        }

        public void Close()
        {
            _state.Close();
        }
    }
}