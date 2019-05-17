using System;

namespace App
{
    internal class Program
    {
        private const string ExitKey = "/q";

        private static void Main()
        {
            Console.WriteLine("----------Design Patterns ----------\n");
            var quitProgram = false;
            while(!quitProgram) 
            {
                Patterns.List();

                Console.WriteLine("Enter the design pattern example you wish to run, enter '/q' to quit");
                var input = Console.ReadLine();

                if (input == ExitKey)
                    quitProgram = true;
                else
                    Patterns.Run(input);
            } 
        }
    }
}
