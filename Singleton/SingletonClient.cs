using DesignPatternBase;
using Singleton.Factory;

namespace Singleton
{
    public class SingletonClient : IDesignPatternClient
    {
        public string Name => "Singleton";
        public void Main()
        {
            var logger = LoggerFactory.Instance.GetLogger();
            logger.Log("this is the singleton logger");
        }
    }
}