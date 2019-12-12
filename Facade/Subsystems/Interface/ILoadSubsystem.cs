namespace Facade.Subsystems.Interface
{
    public interface ILoadSubsystem
    {
        bool IsEligible(Customer c, int amount);
    }
}