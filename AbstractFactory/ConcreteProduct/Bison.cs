using System;

namespace AbstractFactory
{
    public class Bison : IHerbivore
    {
        public void Eat()
        {
            Console.WriteLine("grazes on grass");
        }
    }
}