using Log.Abstract;
using Log.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Log.Loggers
{
    public class ConsoleLogger : LogBase, ILogger
    {
        public void LogDebug(string msg)
        {
            var log = CreateLog(Enum.LogType.Debug, msg);
            Console.WriteLine(log.ToString());
        }

        public void LogError(string msg)
        {
            var log = CreateLog(Enum.LogType.Error, msg);
            Console.WriteLine(log.ToString());
        }

        public void LogInfo(string msg)
        {
            var log = CreateLog(Enum.LogType.Info, msg);
            Console.WriteLine(log.ToString());
        }

        public void LogWarning(string msg)
        {
            var log = CreateLog(Enum.LogType.Warning, msg);
            Console.WriteLine(log.ToString());
        }
    }
}
