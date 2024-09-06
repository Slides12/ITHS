string userInput = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

string[] splitUserInput = userInput.Split(' ');


for (int i = 0; i < splitUserInput.Length; i++)
{

    for (int j = 0; j < splitUserInput.Length; j++)
    {
        if(j == i)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;

        }
        Console.Write($"{splitUserInput[j]} ");
    }
    Console.WriteLine();
}