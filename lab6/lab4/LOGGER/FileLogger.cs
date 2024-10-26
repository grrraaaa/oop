using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.LOGGER
{
    class FileLogger : ILogger
        {
            private readonly string filePath;

            public FileLogger(string filePath) => this.filePath = filePath;

            public void LogInfo(string message) => Log("INFO", message);
            public void LogWarning(string message) => Log("WARNING", message);
            public void LogError(string message) => Log("ERROR", message);

            public void Log(string logType, string message)
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}, {logType}: {message}");
                }
            }
        }
}

