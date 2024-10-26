using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.LOGGER
{
    public class ConsoleLogger : ILogger
    {
        public void LogInfo(string message) => Console.WriteLine($"{DateTime.Now}, INFO: {message}");
        public void LogWarning(string message) => Console.WriteLine($"{DateTime.Now}, WARNING: {message}");
        public void LogError(string message) => Console.WriteLine($"{DateTime.Now}, ERROR: {message}");
    }

}
