namespace OOP_lab_5.Loggers {
    internal abstract class Logger {
        protected List<string> _logMessage;

        protected List<string> _logDate;

        public List<string> logMessage { get => _logMessage; }

        public Logger() {
            _logMessage = new List<string>();
            _logDate = new List<string>();
        }

        public abstract void AddLog(string logMesssage, DateTime logTime);
    }
}
