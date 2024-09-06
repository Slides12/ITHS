string userInput = "Hello world";

foreach (char c in userInput)
{
    if (c == 'o')
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(c);
    }
    else if (c == 'l')
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(c);

    }
    else
    { 
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(c);

    }

}