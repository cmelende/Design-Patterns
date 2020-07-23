using System;
using TemplateMethodPattern.AbstractClass;

namespace TemplateMethodPattern.ConcreteClass
{
    public class Bread : BakedGood
    {
        protected override void DoMixIngredients()
        {
            Console.WriteLine("mixing ingredients for bread");
        }

        protected override void DoBake()
        {
            Console.WriteLine("baking bread!");
        }

        protected override void DoSlice()
        {
            Console.WriteLine("slicing bread");
        }
    }
}