using System;
using Castle.DynamicProxy;

namespace Proxy.CastleProxy
{
    public class Interceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"Before target call {invocation.Method.Name}");
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Target exception {e.Message}");
                //throw;
            }
            finally
            {
                Console.WriteLine($"After target call {invocation.Method.Name}");
            }
        }
    }
}