Console.WriteLine("Skriv en valfri sträng: ");

string userInput = Console.ReadLine();

char[] splitUserInput = userInput.ToCharArray();
bool notRed = false;

for (int i = 0; i < splitUserInput.Length; i++)
{

        if (notRed)
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        if (i > 0 && splitUserInput[0] == splitUserInput[i])
        {
            notRed = true;
        }

        Console.Write($"{splitUserInput[i]}");
}