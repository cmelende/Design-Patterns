using DesignPatternBase;
using StatePattern.ConcreteState;

namespace StatePattern
{

    public class StatePatternClient : IDesignPatternClient
    {
        public string Name => "state example";

        public void Main()
        {
            var context = new Context.Context(new OpenConnection());
            context.Open();

            context.Close();
            context.Close();

            context.Open();
        }
    }
}
