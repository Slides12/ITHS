string userInput = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

string[] splitUserInput = userInput.Split(' ');


for (int i = 0; i < splitUserInput.Length; i++)
{

    for (int j = 0; j <= i; j++)
    {
        Console.Write($"{splitUserInput[i]} ");
    }
    Console.WriteLine();
}