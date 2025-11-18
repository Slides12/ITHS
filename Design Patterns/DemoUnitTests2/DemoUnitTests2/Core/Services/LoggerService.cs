using DemoUnitTests2.Core.Interfaces;

namespace DemoUnitTests2.Core.Services
{
    public class LoggerService
    {
        private readonly ILogger _logger;

        public LoggerService(ILogger logger)
        {
            _logger = logger;
        }

        public void LogMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message)) return;
            _logger.Log(message);
        }
    }
}
