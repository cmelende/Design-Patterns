using System;
using System.Collections.Generic;
using Strategy.SimpleValidationStrategyEx.Strategy;

namespace Strategy.SimpleValidationStrategyEx.Context
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        { }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            object result = _strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            var resultStr = string.Empty;
            foreach (string element in (List<string>) result)
            {
                resultStr += $"{element},";
            }

            Console.WriteLine(resultStr);
        }
    }
}