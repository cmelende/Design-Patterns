using InterpreterPattern.TruthyExample.AbstractExpression;

namespace InterpreterPattern.TruthyExample.NonterminalExpression
{
    public class AndExpression : IExpression
    {
        private readonly IExpression _exp1;
        private readonly IExpression _exp2;

        public AndExpression(IExpression exp1, IExpression exp2)
        {
            _exp1 = exp1;
            _exp2 = exp2;
        }

        public bool Interpret(string context)
        {
            return _exp1.Interpret(context) && _exp2.Interpret(context);
        }
    }
}