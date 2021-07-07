using DecoratorPattern.CarExample.Component;

namespace DecoratorPattern.CarExample.ConcreteComponent
{
    /// <summary>
    ///     Concrete Car
    /// </summary>
    public class EconomyCar : ICar
    {
        public string GetDescription()
        {
            return "Economy Car";
        }

        public double GetCost()
        {
            return 450000.0;
        }
    }
}