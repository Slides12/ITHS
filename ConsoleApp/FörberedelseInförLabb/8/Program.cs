string userInput = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
Console.WriteLine($"{userInput}");
Console.WriteLine("Write a word from the text above: ");
string findString = Console.ReadLine();
int foundIndex = userInput.IndexOf(findString, 0);


for (int i = 0; i < userInput.Length; i++)
{
    if (i == foundIndex)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(userInput.Substring(foundIndex, findString.Length));
        foundIndex = userInput.IndexOf(findString, foundIndex + 1);
        i += findString.Length-1;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;

        Console.Write(userInput[i]);
    }
}