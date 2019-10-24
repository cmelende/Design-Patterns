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
using CompositePattern.ComponentWithChildManagement;
using CompositePattern.ComponentWithoutChildManagement;
using Decorator.CarExample;
using Decorator.MarineArenaExample;
using Proxy.CastleProxy.ClassProxy;
using Proxy.CastleProxy.WithoutTarget;
using Proxy.CastleProxy.WithTarget;
using Proxy.SimpleProxy;

namespace App
{
    public class Patterns
    {
        private static readonly Dictionary<string, Func<IDesignPatternClient>> Clients =
            new Dictionary<string, Func<IDesignPatternClient>>
            {
                {"abstract factory", () => new AbstractFactoryClient()},
                {"factory method", () => new FactoryMethodClient()},
                {"prototype", () => new PrototypeClient()},
                {"builder", () => new BuilderClient()},
                {"singleton", () => new SingletonClient()},
                {"class adapter pattern", () => new ClassClientAdapterClient()},
                {"two way adapter", () => new TwoWayAdapterClient()},
                {"object adapter", () => new ObjectClientAdapter(new TargetDesignPatternClient())},
                {"bridge", () => new BridgeClient()},
                {"component with child management", () => new CompositeWithChildManagementClient() },
                {"component without child management", ()=>new CompositeNoChildManagementClient() },
                {"decorator", () => new DecoratorClient() },
                {"decorator arena", ()=> new DecoratorArenaClient() },
                {"class proxy", ()=>new ClassProxyClient() },
                {"simple proxy", ()=>new MathProxyClient() },
                {"castle proxy without target",  ()=>new CastleProxyInterfaceWithoutTargetClient() },
                {"castle proxy with target",  ()=>new CastleProxyInterfaceWithTargetClient() }
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
            var isValidIndex = int.TryParse(patternName, out var validIndex);

            if (isValidIndex) return Clients.ElementAt(validIndex).Value;

            throw new Exception("Invalid entry, please select a number from the list");
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