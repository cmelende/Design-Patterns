using System;
using System.Collections.Generic;
using System.Linq;
using AbstractFactory;
using Adapter.Adaptees;
using Adapter.Adapter;
using Bridge;
using Builder;
using DesignPatternBase;
using FactoryMethod;
using Prototype;
using Singleton;

namespace App
{
    public class Patterns
    {
        private static readonly Dictionary<string, Func<IDesignPatternClient>> Clients =
            new Dictionary<string, Func<IDesignPatternClient>>
            {
                {"abstract factory", () => new AbstractFactoryExample()},
                {"factory method", () => new FactoryMethodExample()},
                {"prototype", () => new PrototypeExample()},
                {"builder", () => new BuilderExample()},
                {"singleton", () => new SingletonExample()},
                {"class adapter pattern", () => new ClassClientAdapter()},
                {"two way adapter", () => new TwoWayAdapterClient()},
                {"object adapter", () => new ObjectClientAdapter(new TargetDesignPatternClient())},
                {"bridge", () => new BridgeExample()}
            };

        public static void Run(string patternName)
        {
            var client = RetrieveClient(patternName)();
            var headerText = new HeaderText('-', client.Name)
                .RunInBetween(client.Main);

            headerText.Write();
        }

        public static Func<IDesignPatternClient> RetrieveClient(string patternName)
        {
            var isValidName = Clients.TryGetValue(patternName.ToLower(), out var clientConstructor);
            var isValidIndex = int.TryParse(patternName, out var validIndex);

            if (isValidName) return clientConstructor;
            if (isValidIndex) return Clients.ElementAt(validIndex).Value;

            return null;
        }


        public static void ShowCatalog()
        {
            var headerText = new HeaderText('-', "Catalog")
                .RunInBetween(PrintEachClient);
            headerText.Write();
        }

        private static void PrintEachClient()
        {
            var counter = 0;
            foreach (var designPatternClient in Clients)
            {
                Console.WriteLine($"{counter}) {designPatternClient.Value().Name}");
                counter++;
            }
        }
    }
}