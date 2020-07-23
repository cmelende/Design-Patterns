using System;
using TemplateMethodPattern.AbstractClass;

namespace TemplateMethodPattern.ConcreteClass
{
    public class Cake : BakedGood
    {
        protected override void DoMixIngredients()
        {
            Console.WriteLine("mixing ingredients for cake");
        }

        protected override void DoBake()
        {
            Console.WriteLine("baking a cake");
        }

        protected override void DoSlice()
        {
            Console.WriteLine("slicing cake");
        }
    }
}