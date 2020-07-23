using System;
using TemplateMethodPattern.AbstractClass;

namespace TemplateMethodPattern.ConcreteClass
{
    public class Muffin : BakedGood
    {
        protected override void DoMixIngredients()
        {
            Console.WriteLine("mixing ingredients for muffins");
        }

        protected override void DoBake()
        {
            Console.WriteLine("baking muffins");
        }

        protected override void DoSlice()
        {
            Console.WriteLine("slicing off the muffin tops");
        }
    }
}