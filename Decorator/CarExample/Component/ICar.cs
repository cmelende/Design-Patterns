namespace DecoratorPattern.CarExample.Component
{
    /// <summary>
    ///     Car Base component
    /// </summary>
    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }
}