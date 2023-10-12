using System;

namespace OOP_lab_5.Loggers
{
    internal class FileLogger : Logger {
        private const string FileName = "logs.txt";

        public FileLogger() : base() { }

        public override void AddLog(string errMesssage, DateTime logTime) {
            string date = $"{logTime.Year}-{logTime.Month}-{logTime.Day}:{logTime.Hour}.{logTime.Minute}.{logTime.Second}";

            _logMessage.Add(errMesssage);
            _logDate.Add(date);

            File.AppendAllText(FileName, $"{date} | {errMesssage}\n");
        }
    }   
}
