using System;

namespace Adapter.Adaptees
{
    //Cannot change - comes from 3rd party framework or API
    public interface ITargetDesignPatternClient
    {
        void Execute();
        string GetName();
    }

    public class TargetDesignPatternClient : ITargetDesignPatternClient
    {
        public void Execute()
        {
            Console.WriteLine("This is a adapter design pattern by a third party!");
        }

        public string GetName()
        {
            return "Third party adapter client";
        }
    }
}