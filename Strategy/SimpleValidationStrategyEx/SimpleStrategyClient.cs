using System;
using DesignPatternBase;
using Strategy.SimpleValidationStrategyEx.ConcreteStrategy;

namespace Strategy.SimpleValidationStrategyEx
{
    public class SimpleStrategyClient : IDesignPatternClient
    {
        public string Name => "Simple strategy example";

        public void Main()
        {
            var context = new Context.Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}