using Log.Abstract;
using Log.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Log.Logger
{
    public class FileLogger : LogBase, ILogger
    {
        private string _filePath;

        public FileLogger(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            _filePath = Path.HasExtension(path) ? path : Path.Combine(path, "log.txt");
        }

        public void LogDebug(string msg)
        {
            var log = CreateLog(Enum.LogType.Debug, msg);
            WriteLog(log);
        }

        public void LogError(string msg)
        {
            var log = CreateLog(Enum.LogType.Error, msg);
            WriteLog(log);
        }

        public void LogInfo(string msg)
        {
            var log = CreateLog(Enum.LogType.Info, msg);
            WriteLog(log);
        }

        public void LogWarning(string msg)
        {
            var log = CreateLog(Enum.LogType.Warning, msg);
            WriteLog(log);
        }

        private void WriteLog(Models.LogMessage log)
        {
            File.AppendAllText(_filePath, log.ToString() + Environment.NewLine);
        }
    }
}
