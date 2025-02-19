


class Program
{
    static void Main()
    {
        string text = "123122135";
        Console.WriteLine(text.CheckIfStringIsNumeric());
    }
}


public static class CheckString
{
    public static bool CheckIfStringIsNumeric(this string text)
    {
        bool isNumeric = int.TryParse(text, out int value);
        return isNumeric;
    }
}