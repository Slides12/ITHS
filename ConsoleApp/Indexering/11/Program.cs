
Console.WriteLine("Mata in en text: ");

string userInput = Console.ReadLine();

int startIndex = 0;
int stoppIndex = 0;
Console.WriteLine("Skriv in ett start index: ");

string userInput1 = Console.ReadLine();



if (int.TryParse(userInput1, out int x))
{
    startIndex = x;
}
else
{
    Console.WriteLine("Inte en siffra!");
}

Console.WriteLine("Skriv in ett stopp index: ");

string userInput2 = Console.ReadLine();
if (int.TryParse(userInput2, out int y))
{
    stoppIndex = y;
}
else
{
    Console.WriteLine("Inte en siffra!");
}




for(int i =0; i < userInput.Length; i++)
{
    if (i >= startIndex && i<= stoppIndex)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write(userInput[i]);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write(userInput[i]);
    }
}