namespace AbstractFactory
{
    public interface IContinentFactory
    {
        ICarnivore CreateCarnivore();
        IHerbivore CreateHerbivore();
    }
}