namespace ÖvningarUnitTests.Core.Services
{
    public static class ShippingService
    {
        public static double CalculateShippingCost(double weightKg, string zone)
        {
            if (weightKg <= 0)
                throw new ArgumentException("Weight must be positive");

            return zone switch
            {
                "A" => 50 + 10 * weightKg,
                "B" => 70 + 15 * weightKg,
                "C" => 100 + 20 * weightKg,
                _ => throw new ArgumentException("Invalid zone")
            };
        }
    }
}
