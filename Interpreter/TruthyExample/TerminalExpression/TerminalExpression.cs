using Interpreter.TruthyExample.AbstractExpression;

namespace Interpreter.TruthyExample.TerminalExpression
{
    public class TerminalExpression : IExpression
    {
        private readonly string _data;

        public TerminalExpression(string data)
        {
            _data = data;
        }

        public bool Interpret(string context)
        {
            return context.Contains(_data);
        }
    }
}