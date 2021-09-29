using Log.Enum;
using Log.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Log.Abstract
{
    public abstract class LogBase
    {

        public LogMessage CreateLog(LogType type, string msg)
        {
            LogMessage log = new LogMessage(type, msg);
            DoCreateLog();
            return log;
        }

        public void DoCreateLog()
        {
            // Method intentionally left empty.
            // If any class wants implements anything, can override this method
        }
    }
}
