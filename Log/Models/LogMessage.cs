using Log.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Log.Models
{
    public class LogMessage
    {
        public LogType Type { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }


        public LogMessage(LogType type, string message)
        {
            Type = type;
            Message = message;
            Date = DateTime.Now;
        }

        public LogMessage(string message)
        {
            Type = LogType.Info;
            Message = message;
            Date = new DateTime();
        }
        public override string ToString()
        {
            return String.Format("{0} | {1} | {2}", Date.ToString("dd/MM/yyyy hh:mm:ss"), Type, Message);
        }
    }
}
