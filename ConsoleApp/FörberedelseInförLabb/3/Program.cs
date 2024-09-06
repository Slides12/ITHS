string userInput = "Detta är uppgift 3";

for(int i = 0; i < userInput.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.Write("*");
    }
    else
    {
        Console.Write(userInput[i]);
    }
}