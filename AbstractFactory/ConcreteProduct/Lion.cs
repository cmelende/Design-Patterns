using System;

namespace AbstractFactory
{
    public class Lion : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine("stalks and pounces on " + herbivore.GetType().Name);
        }
    }
}