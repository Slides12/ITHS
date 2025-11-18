using System.Text.RegularExpressions;

namespace ÖvningarUnitTests.Helpers
{
    public static class PasswordValidator
    {
        public static bool IsStrongPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            if (password.Length < 8)
                return false;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);

            bool hasSpecial = Regex.IsMatch(password, "[!@#$%&]");

            return hasUpper && hasLower && hasDigit && hasSpecial;
        }
    }
}
