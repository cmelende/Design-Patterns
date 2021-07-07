using DecoratorPattern.CarExample.Component;

namespace DecoratorPattern.CarExample.Decorator
{
    /// <summary>
    ///     Abstract Decorator
    /// </summary>
    public abstract class CarAccessoriesDecorator : ICar
    {
        private readonly ICar _car;

        public CarAccessoriesDecorator(ICar aCar)
        {
            _car = aCar;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual double GetCost()
        {
            return _car.GetCost();
        }
    }
}