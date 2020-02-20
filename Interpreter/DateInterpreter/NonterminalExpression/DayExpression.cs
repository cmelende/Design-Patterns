using Interpreter.DateInterpreter.AbstractExpression;

namespace Interpreter.DateInterpreter.NonterminalExpression
{
    public class DayExpression : IAbstractExpression
    {
        public void Evaluate(Context.Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("DD", context.Date.Day.ToString());
        }
    }
}