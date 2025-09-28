using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Logger
    {
        private static readonly Lazy<Logger> instance = 
            new Lazy<Logger>(() => new Logger());
        private readonly string logFilePath = "log.txt";
        private Logger()
        {
            // Initialize log file or other resources if needed
        }

        public static Logger Instance => instance.Value;

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now}: {message}";
            Console.WriteLine(logEntry);
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }
    }
}
