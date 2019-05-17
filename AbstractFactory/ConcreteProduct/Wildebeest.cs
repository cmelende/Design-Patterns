using System;

namespace AbstractFactory
{
    public class Wildebeest : IHerbivore
    {
        public void Eat()
        {
            Console.WriteLine("chews on leaves");
        }
    }
}