using System;
using Adapter.Adaptees;
using DesignPatternBase;

namespace Adapter.Adapter
{
    public class ClassClientAdapterClient : TargetDesignPatternClient, IDesignPatternClient
    {
        public string Name => GetName();

        public void Main()
        {
            Execute();
        }
    }

    public class TwoWayAdapterClient : IDesignPatternClient
    {
        public string Name => "Two Way Adapter Client";

        public void Main()
        {
            var twoWayAdapter = new ClassClientAdapterClient();

            Console.WriteLine("As TargetDesignPatternClient");

            Console.WriteLine(
                $"{nameof(TargetDesignPatternClient)}.{nameof(TargetDesignPatternClient.Execute)}: {twoWayAdapter.GetName()}");
            twoWayAdapter.Execute();

            Console.WriteLine("As IDesignPatternClient");
            string name = (twoWayAdapter as IDesignPatternClient).Name;

            Console.WriteLine($"{nameof(IDesignPatternClient)}.{nameof(IDesignPatternClient.Main)}: {name}");
            Console.Write($"Running {nameof(IDesignPatternClient)}.{nameof(IDesignPatternClient.Main)}");
            (twoWayAdapter as IDesignPatternClient).Main();
        }
    }
}