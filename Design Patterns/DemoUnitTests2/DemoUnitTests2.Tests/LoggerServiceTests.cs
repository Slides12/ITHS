
using DemoUnitTests2.Core.Interfaces;
using DemoUnitTests2.Core.Services;
using Moq;

namespace DemoUnitTests2.Tests
{
    public class LoggerServiceTests
    {
        [Fact]
        public void LogMessage_CallsLogger_ForMessageNotEmpty()
        {
            var mockLogger = new Mock<ILogger>();
            
            var service = new LoggerService(mockLogger.Object);

            service.LogMessage("Hello World");

            mockLogger.Verify(logger => logger.Log("Hello World"), Times.Once);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void LogMessage_NotCallLogger_WhenMessageEmptyOrNull(string? message)
        {
            var mockLogger = new Mock<ILogger>();

            var service = new LoggerService(mockLogger.Object);

            service.LogMessage(message);

            mockLogger.Verify(logger => logger.Log(It.IsAny<string>()), Times.Never);
        }
    }
}