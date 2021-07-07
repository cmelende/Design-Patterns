using System;
using DesignPatternBase;
using PrototypePattern.ConcretePrototype;
using PrototypePattern.PrototypeManager;

namespace PrototypePattern
{
    public class PrototypeClient : IDesignPatternClient
    {
        public string Name => "Prototype";

        public void Main()
        {
            // Initialize with standard colors
            var colorManager = new ColorManager
            {
                ["red"] = new Color(255, 0, 0),
                ["green"] = new Color(0, 255, 0),
                ["blue"] = new Color(0, 0, 255)
            };

            // Ask user for new color 
            Console.WriteLine("Please enter the color you want to create");

            Console.Write("Red code:");
            int inputRed = int.Parse(Console.ReadLine());

            Console.Write("Green code:");
            int inputGreen = int.Parse(Console.ReadLine());

            Console.Write("Blue code:");
            int inputBlue = int.Parse(Console.ReadLine());

            Console.Write("Name:");
            string name = Console.ReadLine();

            colorManager[name] = new Color(inputRed, inputGreen, inputBlue);

            Console.WriteLine($"You have created the color: {name} with code rgb({inputRed},{inputBlue},{inputGreen})");
        }
    }
}