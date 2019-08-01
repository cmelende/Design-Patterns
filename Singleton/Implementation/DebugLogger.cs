﻿using System;
using Singleton.Interface;

namespace Singleton.Implementation
{
    public class DebugLogger : ILogger
    {
        private static readonly DebugLogger instance = new DebugLogger();
        static DebugLogger()
        {
        }

        private DebugLogger()
        {
        }

        public static ILogger Instance => instance;

        public void Log(string message)
        {
            Console.WriteLine($"Debugger Logger: {message}\n");
        }
    }
}