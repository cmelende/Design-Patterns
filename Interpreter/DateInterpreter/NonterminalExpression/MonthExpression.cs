using InterpreterPattern.DateInterpreter.AbstractExpression;

namespace InterpreterPattern.DateInterpreter.NonterminalExpression
{
    public class MonthExpression : IAbstractExpression
    {
        public void Evaluate(Context.Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }
}