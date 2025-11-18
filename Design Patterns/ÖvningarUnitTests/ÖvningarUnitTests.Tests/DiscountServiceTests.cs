using ÖvningarUnitTests.Core.Services;

namespace ÖvningarUnitTests.Tests
{
    public class DiscountServiceTests
    {
        [Fact]
        public void CalculateDiscountedPrice_MemberGets10PercentDiscount()
        {
            // Arrange
            decimal original = 100m;

            // Act
            decimal result = DiscountService.CalculateDiscountedPrice(original, 30, true);

            // Assert
            Assert.Equal(90m, result);
        }

        [Fact]
        public void CalculateDiscountedPrice_SeniorMemberGets15PercentDiscount()
        {
            // Arrange
            decimal original = 200m;

            // Act
            decimal result = DiscountService.CalculateDiscountedPrice(original, 70, true);

            // Assert
            Assert.Equal(170m, result); // 200 * 0.85
        }

        [Fact]
        public void CalculateDiscountedPrice_SeniorWithoutMembershipGets5PercentDiscount()
        {
            // Arrange
            decimal original = 100m;

            // Act
            decimal result = DiscountService.CalculateDiscountedPrice(original, 70, false);

            // Assert
            Assert.Equal(95m, result);
        }

        [Fact]
        public void CalculateDiscountedPrice_NegativePriceThrowsException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                DiscountService.CalculateDiscountedPrice(-10m, 30, false));
        }

        [Fact]
        public void CalculateDiscountedPrice_NoDiscountPriceUnchanged()
        {
            // Arrange
            decimal original = 150m;

            // Act
            decimal result = DiscountService.CalculateDiscountedPrice(original, 30, false);

            // Assert
            Assert.Equal(150m, result);
        }

        [Fact]
        public void CalculateDiscountedPrice_RoundsCorrectly()
        {
            // Arrange
            decimal original = 99.999m;

            // Act
            decimal result = DiscountService.CalculateDiscountedPrice(original, 30, true);

            // 10 % rabatt → 89.9991 → avrundas till 90.00
            Assert.Equal(90.00m, result);
        }
    }
}
