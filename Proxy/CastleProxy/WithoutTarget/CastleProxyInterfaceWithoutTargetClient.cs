using Castle.DynamicProxy;
using DesignPatternBase;
using Proxy.CastleProxy;

namespace ProxyPattern.CastleProxy.WithoutTarget
{
    public class CastleProxyInterfaceWithoutTargetClient : IDesignPatternClient
    {
        public string Name => "Castle Proxy Interface Without Target Example";

        public void Main()
        {
            var proxy = new ProxyGenerator()
                .CreateInterfaceProxyWithoutTarget<IPerson>(
                    new Interceptor());
            proxy.FirstName = "Scooby";
            proxy.LastName = "Doo";
        }
    }
}