using DesignPatternBase;
using SingletonPattern.Factory;
using SingletonPattern.Interface;

namespace SingletonPattern
{
    public class SingletonClient : IDesignPatternClient
    {
        public string Name => "Singleton";

        public void Main()
        {
            ILogger logger = LoggerFactory.Instance.GetLogger();
            logger.Log("this is the singleton logger");
        }
    }
}