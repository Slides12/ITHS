namespace ÖvningarUnitTests.Core.Services
{
    public static class InterestService
    {
        public static decimal CalculateInterest(decimal balance, decimal annualPercentageRate, int days)
        {
            if (balance < 0)
                throw new ArgumentException("Balance cannot be negative");

            if (annualPercentageRate < 0)
                throw new ArgumentException("APR cannot be negative");

            if (days < 0)
                throw new ArgumentException("Days cannot be negative");

            return balance * (annualPercentageRate / 100m) * (days / 365m);
        }
    }
}
