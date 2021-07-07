using System;
using AbstractFactory.AbstractProduct;
using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class Lion : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine("stalks and pounces on " + herbivore.GetType().Name);
        }
    }
}