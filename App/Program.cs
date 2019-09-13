using System;

namespace App
{
    class Program
    {
        private const string ExitKey = "/q";

        static void Main(string [] args)
        {
            Console.WriteLine("----------Design Patterns ----------\n");
            var quitProgram = false;
            while(!quitProgram) 
            {
                Patterns.ShowCatalog();

                Console.WriteLine("Enter the design pattern example you wish to run, enter '/q' to quit");

                var input = Console.ReadLine();
                quitProgram = input == ExitKey;

                if (!quitProgram) Run(input);
            } 
        }

        private static void Run(string input)
        {
            try
            {
                Patterns.Run(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
