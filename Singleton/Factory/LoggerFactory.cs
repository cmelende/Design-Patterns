using Singleton.Implementation;
using Singleton.Interface;

namespace Singleton.Factory
{
    public class LoggerFactory
    {
        private static readonly LoggerFactory instance = new LoggerFactory();
        static LoggerFactory()
        {
        }

        private LoggerFactory()
        {
        }

        public static LoggerFactory Instance => instance;

        public ILogger GetLogger()
        {
#if DEBUG
            return DebugLogger.Instance;
#endif
            return ProductionLogger.Instance;
        }
    }
}
