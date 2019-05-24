using System;
using DesignPatternBase;
using Prototype.ConcretePrototype;
using Prototype.PrototypeManager;

namespace Prototype
{
    public class PrototypeExample : IDesignPatternClient
    {
        public string Name => "Prototype";
        public void Main()
        {
            var colormanager = new ColorManager();

            // Initialize with standard colors

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors

            var color1 = colormanager["red"].Clone() as Color;
            var color2 = colormanager["peace"].Clone() as Color;
            var color3 = colormanager["flame"].Clone() as Color;

            // Ask user for new color 
            Console.WriteLine("Please enter the color you want to create");

            Console.Write("R:");
            var inputRed = int.Parse(Console.ReadLine());

            Console.Write("G:");
            var inputGreen = int.Parse(Console.ReadLine());

            Console.Write("B:");
            var inputBlue = int.Parse(Console.ReadLine());

            Console.Write("Name:");
            string name = Console.ReadLine();

            colormanager[name] = new Color(inputRed, inputGreen, inputBlue);

            var newColor = colormanager[name].Clone() as Color;

            Console.WriteLine($"You have created the color: {name} with code rgb({inputRed},{inputBlue},{inputGreen})");
        }
    }
}