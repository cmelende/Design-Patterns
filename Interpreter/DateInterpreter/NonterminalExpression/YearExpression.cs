using Interpreter.DateInterpreter.AbstractExpression;

namespace Interpreter.DateInterpreter.NonterminalExpression
{
    public class YearExpression : IAbstractExpression
    {
        public void Evaluate(Context.Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }
}