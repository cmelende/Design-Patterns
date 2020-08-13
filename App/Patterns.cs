using System;
using System.Collections.Generic;
using System.Linq;
using AbstractFactory;
using Adapter.Adaptees;
using Adapter.Adapter;
using Bridge;
using Builder;
using ChainOfResponsibility;
using Command;
using CompositePattern.ComponentWithChildManagement;
using CompositePattern.ComponentWithoutChildManagement;
using Decorator.CarExample;
using Decorator.MarineArenaExample;
using DesignPatternBase;
using Facade.Examples;
using FactoryMethod;
using Flyweight;
using Interpreter.DateInterpreter;
using Interpreter.TruthyExample;
using IteratorPattern;
using Mediator;
using MementoPattern;
using ObserverPattern;
using Prototype;
using Proxy.CastleProxy.ClassProxy;
using Proxy.CastleProxy.WithoutTarget;
using Proxy.CastleProxy.WithTarget;
using Proxy.SimpleProxy;
using Singleton;
using StatePattern;
using Strategy.SimpleValidationStrategyEx;
using Strategy.ValidationStrategyEx;
using TemplateMethodPattern;
using VisitorPattern;

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
                {"component with child management", () => new CompositeWithChildManagementClient()},
                {"component without child management", () => new CompositeNoChildManagementClient()},
                {"decorator", () => new DecoratorClient()},
                {"decorator arena", () => new DecoratorArenaClient()},
                {"class proxy", () => new ClassProxyClient()},
                {"simple proxy", () => new MathProxyClient()},
                {"castle proxy without target", () => new CastleProxyInterfaceWithoutTargetClient()},
                {"castle proxy with target", () => new CastleProxyInterfaceWithTargetClient()},
                {"facade example", () => new FacadeExample()},
                {"dependency injection facade example", () => new DiFacadeExample()},
                {"flyweight", ()=> new FlyweightShapeClient() },
                {"chain of responsibility", () => new ChainOfResponsibilityClient() },
                {"command", ()=>new CommandClient() },
                {"date interpreter example", ()=> new DateInterpreterExample() },
                {"interpreter example", ()=> new TruthyInterpreterExample() },
                {"iterator example", ()=> new IteratorDesignPattern() },
                {"mediator example", () => new MediatorExampleClient() },
                {"memento adventure", ()=>new MementoAdventureExample() },
                {"observer example", ()=>new ObserverClient() },
                {"state example", ()=>new StatePatternClient() },
                {"simple stratege", ()=>new SimpleStrategyClient() },
                {"validation strategy", ()=>new ValidationStrategyClient() },
                {"template method example", () => new TemplateMethodExample()},
                {"visitor example", ()=>new VisitorExample()}
            };

        public static void Run(string patternName)
        {
            IDesignPatternClient client = RetrieveClient(patternName)();
            HeaderText headerText = new HeaderText('-', client.Name)
                .RunInBetween(client.Main);

            headerText.Write();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static Func<IDesignPatternClient> RetrieveClient(string patternName)
        {
            bool isValidIndex = int.TryParse(patternName, out int validIndex);

            if (isValidIndex) return Clients.ElementAt(validIndex).Value;

            throw new Exception("Invalid entry, please select a number from the list");
        }


        public static void ShowCatalog()
        {
            HeaderText headerText = new HeaderText('-', "Catalog")
                .RunInBetween(PrintEachClient);
            headerText.Write();
        }

        private static void PrintEachClient()
        {
            var counter = 0;
            foreach (KeyValuePair<string, Func<IDesignPatternClient>> designPatternClient in Clients)
            {
                Console.WriteLine($"{counter}) {designPatternClient.Value().Name}");
                counter++;
            }
        }
    }
}