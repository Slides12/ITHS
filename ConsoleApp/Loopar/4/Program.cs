Console.WriteLine("Skriv in ett tal: ");
string userInput = Console.ReadLine();
int x;

for(int i = 1; i < 10; i++)
{
    if (int.TryParse(userInput, out x))
    {
        x = int.Parse(userInput);
    }
    else
    {
        Console.WriteLine("Inte ett tal.");
            break;
    }
    Console.WriteLine(x * i);
}