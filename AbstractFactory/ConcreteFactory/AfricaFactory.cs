namespace AbstractFactory
{
    public class AfricaFactory : IContinentFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}