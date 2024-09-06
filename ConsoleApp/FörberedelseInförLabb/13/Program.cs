string userInput = "abcdefghijklmnopqrstuvwxyz";

char[] splitUserInput = userInput.ToCharArray();


for (int i = 0; i < splitUserInput.Length-4; i++)
{

    for (int j = 0; j < splitUserInput.Length; j++)
    {
        if (j >= i && j < i + 5)
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