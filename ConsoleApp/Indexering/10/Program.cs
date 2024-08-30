Console.WriteLine("Skriv en text snutt: ");

string userInput = Console.ReadLine();

Console.WriteLine("Skriv en bokstav: ");

string userInput1 = Console.ReadLine();

foreach (char c in userInput)
{
    if (userInput1 != c.ToString())
    {
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write(c);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write(c);
    }
}