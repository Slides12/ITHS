Random rnd = new Random();
int guess = rnd.Next(1, 100);
int computerGuess = 0;
int x = 0;
int count = 0;

while (true)
{

    Console.WriteLine("Gissa en siffra");


    x = rnd.Next(1,100);
    computerGuess = x;
    Console.WriteLine(computerGuess);

    if (computerGuess > guess)
    {
        Console.WriteLine("För högt. Gissa igen.\n");
        computerGuess = rnd.Next(1, x);
        count++;
        continue;
    }
    else if (computerGuess < guess)
    {
        Console.WriteLine("För lågt. Gissa igen.\n");
        computerGuess = rnd.Next(x, 100);

        count++;
        continue;

    }
    else
    {
        Console.WriteLine($"Du gissade rätt! Du löste det på {count} försök! Snyggt!");
        break;
    }

}