namespace Interpreter.TruthyExample.AbstractExpression
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}