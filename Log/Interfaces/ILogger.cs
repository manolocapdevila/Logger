using System;
using System.Collections.Generic;
using System.Text;

namespace Log.Interfaces
{
    public interface ILogger
    {
        public void LogInfo(string msg);
        public void LogError(string msg);
        public void LogDebug(string msg);
        public void LogWarning(string msg);

    }
}
