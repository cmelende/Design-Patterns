namespace InterpreterPattern.TruthyExample.AbstractExpression
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}