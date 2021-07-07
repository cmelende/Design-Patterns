namespace FacadePattern.Subsystems.Interface
{
    public interface ICreditSubsystem
    {
        bool IsEligible(Customer c, int amount);
    }
}