namespace ÖvningarUnitTests.Helpers
{
    public static class PersonnummerValidator
    {
        public static bool IsValidSwedishPersonnummer(string pnr)
        {
            if (string.IsNullOrWhiteSpace(pnr) || pnr.Length != 12 || !pnr.All(char.IsDigit))
                return false;

            string datePart = pnr.Substring(0, 8);
            if (!DateTime.TryParseExact(datePart, "yyyyMMdd", null,
                System.Globalization.DateTimeStyles.None, out _))
                return false;

            string luhnPart = pnr.Substring(2); // Use 10 digits
            return LuhnCheck(luhnPart);
        }

        private static bool LuhnCheck(string number)
        {
            int sum = 0;
            bool alternate = false;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';
                if (alternate)
                {
                    digit *= 2;
                    if (digit > 9)
                        digit -= 9;
                }
                sum += digit;
                alternate = !alternate;
            }

            return sum % 10 == 0;
        }
    }
}
