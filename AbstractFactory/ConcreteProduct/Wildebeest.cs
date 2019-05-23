using System;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class Wildebeest : IHerbivore
    {
        public void Eat()
        {
            Console.WriteLine("chews on leaves");
        }
    }
}