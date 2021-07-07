﻿using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactory.AbstractProduct
{
    public interface ICarnivore
    {
        void Eat(IHerbivore herbivore);
    }
}