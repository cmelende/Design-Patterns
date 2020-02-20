using System;
using DesignPatternBase;
using Interpreter.TruthyExample.AbstractExpression;
using Interpreter.TruthyExample.NonterminalExpression;

namespace Interpreter.TruthyExample
{
    public class TruthyInterpreterExample : IDesignPatternClient
    {
        public string Name => "Truthy interpreter example";
        public void Main()
        {
            IExpression person1 = new TerminalExpression.TerminalExpression("Kushagra");
            IExpression person2 = new TerminalExpression.TerminalExpression("Lokesh");
            IExpression isSingle = new OrExpression(person1, person2);

            IExpression vikram = new TerminalExpression.TerminalExpression("Vikram");
            IExpression committed = new TerminalExpression.TerminalExpression("Committed");
            IExpression isCommitted = new AndExpression(vikram, committed);

            Console.WriteLine(isSingle.Interpret("Kushagra"));
            Console.WriteLine(isSingle.Interpret("Lokesh"));
            Console.WriteLine(isSingle.Interpret("Achint"));
            Console.WriteLine(isCommitted.Interpret("Committed, Vikram"));
            Console.WriteLine(isCommitted.Interpret("Single, Vikram"));
        }
    }
}