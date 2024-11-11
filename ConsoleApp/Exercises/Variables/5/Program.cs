string userInput = "";
int x = 0;

while(true)
{
    Console.WriteLine("Skriv in ett tal: ");
    userInput = Console.ReadLine();

    if(!int.TryParse(userInput, out x)){
        Console.WriteLine("Inte en siffra. Testa igen.\n");
        continue;
    }
    else
    {
        x= int.Parse(userInput);
    }

    Console.WriteLine($"{x*2.0} är dubbelt så mycket som {x}");
    Console.WriteLine($"{x / 2.0} är hälften så mycket som {x}");

}