using SingletonPattern.Implementation;
using SingletonPattern.Interface;

namespace SingletonPattern.Factory
{
    public class LoggerFactory
    {
        static LoggerFactory()
        {
        }

        private LoggerFactory()
        {
        }

        public static LoggerFactory Instance { get; } = new LoggerFactory();

        public ILogger GetLogger()
        {
#if DEBUG
            return DebugLogger.Instance;
#endif
            return ProductionLogger.Instance;
        }
    }
}