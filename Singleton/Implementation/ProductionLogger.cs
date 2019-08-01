using System;
using Singleton.Interface;

namespace Singleton.Implementation
{
    public class ProductionLogger : ILogger
    {
        private static readonly ProductionLogger instance = new ProductionLogger();
        static ProductionLogger()
        {
        }

        private ProductionLogger()
        {
        }

        public static ILogger Instance => instance;

        public void Log(string message)
        {
            Console.WriteLine($"Production Logger: {message}\n");
        }
    }
}