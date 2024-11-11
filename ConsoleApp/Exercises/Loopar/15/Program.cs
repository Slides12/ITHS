Random rnd = new Random();  
int x = 0; //Sten = 1, Sax = 2, Påse = 3
int playerPoints = 0; //Sten = 1, Sax = 2, Påse = 3
int pcPoints = 0; //Sten = 1, Sax = 2, Påse = 3







while (true)
{
    Console.WriteLine("Sten, sax eller påse?");
    string playerChoice = Console.ReadLine().ToLower();
    x = rnd.Next(1, 3); //Sten = 1, Sax = 2, Påse = 3

    if(playerChoice == "sten")
    {
        if(x == 1)
        {
            Console.WriteLine("Oj, ni spelade lika! Datorn spelade: ");
            StenSaxEllerPås();
        }
        else if(x == 3)
        {
            Console.WriteLine("Datorn vann! Den spelade: ");
            StenSaxEllerPås();
            pcPoints++;
        }
        else
        {
            
            Console.WriteLine("Du vann! Bra jobbat. Datorn spelade:  ");
            StenSaxEllerPås();
            playerPoints++;
        }
    }
    else if (playerChoice == "sax")
    {
        if (x == 2)
        {
            Console.WriteLine("Oj, ni spelade lika! Datorn spelade: ");
            StenSaxEllerPås();
        }
        else if (x == 1)
        {
            Console.WriteLine("Datorn vann! Den spelade: ");
            StenSaxEllerPås();
            pcPoints++;
        }
        else
        {

            Console.WriteLine("Du vann! Bra jobbat. Datorn spelade:  ");
            StenSaxEllerPås();
            playerPoints++;
        }
    }
    else if (playerChoice == "påse")
    {
        if (x == 3)
        {
            Console.WriteLine("Oj, ni spelade lika! Datorn spelade: ");
            StenSaxEllerPås();
        }
        else if (x == 2)
        {
            Console.WriteLine("Datorn vann! Den spelade: ");
            StenSaxEllerPås();
            pcPoints++;
        }
       
        else
        {

            Console.WriteLine("Du vann! Bra jobbat. Datorn spelade:  ");
            StenSaxEllerPås();
            playerPoints++;
        }
    }
    else if (playerChoice == "")
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste välja Sten, sax eller påse. Testa igen.");
    }
    Console.WriteLine($"Du har {playerPoints} poäng medans datorn har {pcPoints} poäng.\n");

}


void StenSaxEllerPås(){
    if (x == 1)
    {
        Console.WriteLine("Sten\n"); ;
    }
    else if (x == 2)
    {
        Console.WriteLine("Sax\n"); 
    }
    else
    {
        Console.WriteLine("Påse\n");
    }
}