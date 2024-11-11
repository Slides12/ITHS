Random rnd = new Random();
int guess = rnd.Next(1, 100);
string userInput = "";
int x = 0;  
int count = 0;

while (true)
{

    Console.WriteLine("Gissa en siffra");

    userInput = Console.ReadLine();

    if(int.TryParse(userInput, out int g))
    {
        x = g;
    }
    else
    {
        Console.WriteLine("Inte en siffra. Testa igen. \n");
        continue;
    }


    if (x > guess)
    {
        Console.WriteLine("För högt. Gissa igen.\n");
        count++;
        continue;
    }
    else if (x < guess)
    {
        Console.WriteLine("För lågt. Gissa igen.\n");
        count++;
        continue;

    }
    else
    {
        Console.WriteLine($"Du gissade rätt! Du löste det på {count} försök! Snyggt!");
        break;
    }

}