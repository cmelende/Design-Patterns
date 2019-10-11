using Decorator.CarExample.Component;

namespace Decorator.CarExample.ConcreteComponent
{
    /// <summary>   
    /// Concrete Car   
    /// </summary>   
    public class DeluxeCar : ICar
    {
        public string GetDescription()
        {
            return "Deluxe Car";
        }

        public double GetCost()
        {
            return 750000.0;
        }
    }
}