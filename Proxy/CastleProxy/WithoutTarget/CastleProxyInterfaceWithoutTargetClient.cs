using Castle.DynamicProxy;
using DesignPatternBase;

namespace Proxy.CastleProxy.WithoutTarget
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
