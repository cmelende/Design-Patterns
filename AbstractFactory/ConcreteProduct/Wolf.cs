using System;
using AbstractFactory.AbstractProduct;
using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class Wolf : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine("sneaks and bites and eats " + herbivore.GetType().Name);
        }
    }
}