using Castle.DynamicProxy;
using DesignPatternBase;

namespace Proxy.CastleProxy.ClassProxy
{
    public class ClassProxyClient : IDesignPatternClient
    {
        public string Name => "Class Proxy Example";
        public void Main()
        {
            var proxy = new ProxyGenerator()
                .CreateClassProxy<MyClassProxy>(
                    new Interceptor());
            proxy.Flag = true;
            proxy.Execute();
        }
    }
}