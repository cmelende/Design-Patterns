using System;

namespace AbstractFactory
{
    public class Wolf : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine("sneaks and bites and eats " + herbivore.GetType().Name);
        }
    }
}