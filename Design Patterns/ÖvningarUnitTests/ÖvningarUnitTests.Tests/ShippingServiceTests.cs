
using ÖvningarUnitTests.Core.Services;

namespace ÖvningarUnitTests.Tests
{
    public class ShippingServiceTests
    {
        [Fact]
        public void ShippingService_Calculate_ZoneA()
        {
            double test = 5;
            double expected = test * 10 + 50;

            double result = ShippingService.CalculateShippingCost(test, "A");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShippingService_Calculate_ZoneB()
        {
            double test = 5;
            double expected = test * 15 + 70;

            double result = ShippingService.CalculateShippingCost(test, "B");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShippingService_Calculate_ZoneC()
        {
            double test = 5;
            double expected = test * 20 + 100;

            double result = ShippingService.CalculateShippingCost(test, "C");

            Assert.Equal(expected, result);
        }


        [Fact]
        public void ShippingService_ExceptionForNonExistingZone()
        {
            Assert.Throws<ArgumentException>(() => ShippingService.CalculateShippingCost(5, "D"));
        }

        [Fact]
        public void ShippingService_ExceptionNegativeWeight()
        {
            Assert.Throws<ArgumentException>(() => ShippingService.CalculateShippingCost(-1, "A"));
        }

    }
}
