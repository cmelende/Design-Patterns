using System;
using DesignPatternBase;
using ProxyPattern.SimpleProxy.Proxy;

namespace ProxyPattern.SimpleProxy
{
    public class MathProxyClient : IDesignPatternClient
    {
        public string Name => "Math Proxy Example";

        public void Main()
        {
            var proxy = new MathProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
        }
    }
}