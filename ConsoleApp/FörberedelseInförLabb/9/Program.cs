string userInput = "Hello world!";

for (int i = 0; i < userInput.Length; i++)
{
    Console.WriteLine();
    for (int j = 0; j <= i; j++)
    {
        Console.Write(userInput[i]);
    }

}