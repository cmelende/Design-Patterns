using System;
using System.Collections.Generic;
using DesignPatternBase;
using Interpreter.DateInterpreter.AbstractExpression;
using Interpreter.DateInterpreter.NonterminalExpression;

namespace Interpreter.DateInterpreter
{
    public class DateInterpreterExample : IDesignPatternClient
    {
        public string Name => "Date Interpreter pattern";

        public void Main()
        {
            var objExpressions = new List<IAbstractExpression>();
            var context = new Context.Context(DateTime.Now);
            Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");
            context.Expression = Console.ReadLine();
            var strArray = context.Expression?.Split(' ') ?? new string[]{};
            foreach (string item in strArray)
            {
                if (item == "DD")
                {
                    objExpressions.Add(new DayExpression());
                }
                else if (item == "MM")
                {
                    objExpressions.Add(new MonthExpression());
                }
                else if (item == "YYYY")
                {
                    objExpressions.Add(new YearExpression());
                }
            }
            objExpressions.Add(new SeparatorExpression());
            foreach (IAbstractExpression obj in objExpressions)
            {
                obj.Evaluate(context);
            }
            Console.WriteLine(context.Expression);
            Console.Read();
        }
    }
}
