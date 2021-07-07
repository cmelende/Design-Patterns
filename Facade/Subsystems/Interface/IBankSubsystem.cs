namespace FacadePattern.Subsystems.Interface
{
    public interface IBankSubsystem
    {
        bool IsEligible(Customer c, int amount);
    }
}