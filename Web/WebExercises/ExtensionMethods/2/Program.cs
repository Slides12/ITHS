

class Program
{
    static void Main()
    {
        string text = null;
        Console.WriteLine($"{text.ConvertAgain()} is type: {text.ConvertAgain().GetType()}");
    }
}





public static class ConvertStringToInt
{
    public static int ConvertAgain(this string text)
    {
        return int.TryParse(text, out int value) ? value : 1337;
    }
}