using System;
using Adapter.Adaptees;
using DesignPatternBase;

namespace Adapter.Adapter
{
    public class ClassClientAdapter : TargetDesignPatternClient, IDesignPatternClient
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
            var twoWayAdapter = new ClassClientAdapter();

            Console.WriteLine("As TargetDesignPatternClient");

            Console.WriteLine(
                $"{nameof(TargetDesignPatternClient)}.{nameof(TargetDesignPatternClient.Execute)}: {(twoWayAdapter as TargetDesignPatternClient).GetName()}");
            (twoWayAdapter as TargetDesignPatternClient).Execute();

            Console.WriteLine("As IDesignPatternClient");
            var name = (twoWayAdapter as IDesignPatternClient).Name;

            Console.WriteLine($"{nameof(IDesignPatternClient)}.{nameof(IDesignPatternClient.Main)}: {name}");
            Console.Write($"Running {nameof(IDesignPatternClient)}.{nameof(IDesignPatternClient.Main)}");
            (twoWayAdapter as IDesignPatternClient).Main();
        }
    }
}