using System;
using DesignPatternBase;
using Prototype.ConcretePrototype;
using Prototype.PrototypeManager;

namespace Prototype
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

            Console.Write("R:");
            var inputRed = int.Parse(Console.ReadLine());

            Console.Write("G:");
            var inputGreen = int.Parse(Console.ReadLine());

            Console.Write("B:");
            var inputBlue = int.Parse(Console.ReadLine());

            Console.Write("Name:");
            string name = Console.ReadLine();

            colorManager[name] = new Color(inputRed, inputGreen, inputBlue);

            Console.WriteLine($"You have created the color: {name} with code rgb({inputRed},{inputBlue},{inputGreen})");
        }
    }
}