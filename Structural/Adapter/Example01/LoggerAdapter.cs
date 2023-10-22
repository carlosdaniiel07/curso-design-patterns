namespace curso_design_patterns.Structural.Adapter.Example01
{
    public class LoggerAdapter : ILogger
    {
        private readonly ICustomLogger _customLogger;

        public LoggerAdapter(ICustomLogger customLogger)
        {
            _customLogger = customLogger;
        }

        public void LogError(string message) =>
            _customLogger.LogError(message);

        public void LogInfo(string message) =>
            _customLogger.LogInfo(message);

        public void LogWarning(string message) =>
            _customLogger.LogWarning(message);
    }
}
