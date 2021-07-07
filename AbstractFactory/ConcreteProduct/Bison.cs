using System;
using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class Bison : IHerbivore
    {
        public void Eat()
        {
            Console.WriteLine("grazes on grass");
        }
    }
}