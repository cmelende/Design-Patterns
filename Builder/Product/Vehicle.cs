using System;
using System.Collections.Generic;

namespace BuilderPattern.Product
{
    public class Vehicle
    {
        public Vehicle()
        {
            Accessories = new List<string>();
        }

        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public List<string> Accessories { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Body: {0}", Body);
            Console.WriteLine("Transmission: {0}", Transmission);
            Console.WriteLine("Accessories:");
            foreach (string accessory in Accessories) Console.WriteLine("\t{0}", accessory);
        }
    }
}