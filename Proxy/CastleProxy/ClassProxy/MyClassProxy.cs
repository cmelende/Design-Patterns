using System;

namespace Proxy.CastleProxy.ClassProxy
{
    public class MyClassProxy
    {
        public virtual bool Flag { get; set; }

        public virtual void Execute()
        {
            Console.WriteLine("Execute method called");
        }
    }
}
