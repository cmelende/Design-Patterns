using System.Collections.Generic;
using Strategy.SimpleValidationStrategyEx.Strategy;

namespace Strategy.SimpleValidationStrategyEx.ConcreteStrategy
{
    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list?.Sort();
            list?.Reverse();

            return list;
        }
    }
}