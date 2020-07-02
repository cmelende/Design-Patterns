using System;

namespace Strategy.ValidationStrategyEx.Models
{
    public class Entity
    {
        public void Save()
        {
            Console.WriteLine("Saving...");
        }

        public void Update()
        {
            Console.WriteLine("Updating...");
        }
    }
}