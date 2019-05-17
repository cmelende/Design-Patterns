﻿using System;
using System.Collections.Generic;
using AbstractFactory;
using DesignPatternBase;

namespace App
{
    public static class Patterns
    {
        private static readonly Dictionary<string, IDesignPatternClient> Clients =
            new Dictionary<string, IDesignPatternClient>
            {
                {"abstract factory", new AbstractFactoryExample()}
            };

        public static void Run(string patternName)
        {
            var client = Clients[patternName.ToLower()];
            if (client == null)
            {
                Console.WriteLine("Invalid Pattern");
                return;
            }

            Console.WriteLine($"{Filler(10)}{client.Name}{Filler(10)}");
            client.Run();
            Console.WriteLine($"{Filler(client.Name.Length + 20)}\n");
        }

        private static string Filler(int amount)
        {
            var space = string.Empty;

            for (var i = 0; i < amount; i++) space += "-";

            return space;
        }

        public static void List()
        {
            var catalog = "Catalog";
            var counter = 1;

            Console.WriteLine($"{Filler(10)}{catalog}{Filler(10)}");
            foreach (var designPatternClient in Clients)
            {
                Console.WriteLine($"{counter}) {designPatternClient.Value.Name}");
                counter++;
            }
            Console.WriteLine($"{Filler(20 + catalog.Length)}\n");
        }
    }
}