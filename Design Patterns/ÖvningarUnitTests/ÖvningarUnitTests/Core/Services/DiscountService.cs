namespace ÖvningarUnitTests.Core.Services
{
    public static class DiscountService
    {
        public static decimal CalculateDiscountedPrice(decimal originalPrice, int customerAge, bool hasMembership)
        {
            if (originalPrice < 0)
                throw new ArgumentException("Price cannot be negative");

            decimal discount = 0m;

            if (hasMembership)
                discount += 0.10m;

            if (customerAge >= 65)
                discount += 0.05m;

            decimal price = originalPrice * (1 - discount);

            return Math.Round(price, 2);
        }
    }
}
