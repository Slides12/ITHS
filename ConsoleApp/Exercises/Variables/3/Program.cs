string password = "hallåEller";
string userInput = "";

while (true)
{
    Console.WriteLine("Skriv in lösenordet: ");
    userInput = Console.ReadLine(); 
    if (userInput != password)
    {
        Console.WriteLine("Fel Lösenord! \nTesta igen.");
        Console.WriteLine();
    }
    else if (userInput == password)
    {
        Console.WriteLine($"Lösenordet är {password}");
        break;
    }
    else
    {
        continue;
    }
}