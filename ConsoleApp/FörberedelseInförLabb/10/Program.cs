string userInput = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

for (int i = 0; i < userInput.Length; i++)
{
    Console.WriteLine();
    for (int j = 0; j <= i; j++)
    {
        Console.Write(userInput[j]);
    }

}