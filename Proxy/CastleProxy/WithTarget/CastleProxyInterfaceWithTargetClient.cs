using Castle.DynamicProxy;
using DesignPatternBase;

namespace Proxy.CastleProxy.WithTarget
{
    public class CastleProxyInterfaceWithTargetClient : IDesignPatternClient
    {
        public string Name => "Castle Proxy Interface With Target Example";
        public void Main()
        {
            var proxy = (IPerson)new ProxyGenerator()
                .CreateInterfaceProxyWithTarget(
                    typeof(IPerson),
                    new Person(),
                    new Interceptor());
            proxy.FirstName = "Scooby";
            proxy.LastName = "Doo";
        }
    }
}