using InterpreterPattern.DateInterpreter.AbstractExpression;

namespace InterpreterPattern.DateInterpreter.NonterminalExpression
{
    public class SeparatorExpression : IAbstractExpression
    {
        public void Evaluate(Context.Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}