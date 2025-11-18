using ÖvningarUnitTests.Core.Services;

namespace ÖvningarUnitTests.Tests
{
    public class DueDateServiceTests
    {

        [Fact]
        public void DaysUntilDue_CorrectOutput()
        {
            DateTime test = new DateTime(2025, 12, 25);
            DateTime today = DateTime.Today;

            int result = DueDateService.DaysUntilDue(test, today);

            Assert.Equal((test - today).Days, result);
        }

        [Fact]
        public void DaysUntilDue_SameDayTest()
        {
            DateTime test = DateTime.Today;
            DateTime today = DateTime.Today;

            int result = DueDateService.DaysUntilDue(test, today);

            Assert.Equal(0, result);
        }

        [Fact]
        public void DaysUntilDue_YesterDayTest()
        {
            DateTime test = new DateTime(2025, 11, 17);
            DateTime today = DateTime.Today;

            int result = DueDateService.DaysUntilDue(test, today);

            Assert.Equal(0, result);
        }

    }
}
