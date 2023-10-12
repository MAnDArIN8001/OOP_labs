using System;
using System.Runtime.CompilerServices;

namespace OOP_lab_5.Loggers {
    internal class ConsoleLogger : Logger {
        public ConsoleLogger() : base() {  }

        public string this[int index] {
            get => $"{_logDate[index]}::{_logMessage[index]}";
        }

        public override void AddLog(string logMesssage, DateTime logTime) {
            string time = $"{logTime.Year}-{logTime.Month}-{logTime.Day}:{logTime.Hour}.{logTime.Minute}.{logTime.Second}";

            _logMessage.Add(logMesssage);
            _logDate.Add(time);
        }
    }
}
