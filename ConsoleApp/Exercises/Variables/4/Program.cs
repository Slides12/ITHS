string tal = "";
int x = 0;
while(true)
{
    Console.WriteLine("Skriv ett tal: ");
    tal = Console.ReadLine();
    if(int.TryParse(tal, out x))
    {
        x = int.Parse(tal);

    }
    else
    {
        Console.WriteLine("Inget tal hörru. Testa igen.\n");
        continue;
    }
    if (x < 100)
    {
        Console.WriteLine("ditt tal är mindre än 100\n");
    }
    else
    {
        
            Console.WriteLine("ditt tal är större än 100\n");

        
    }
}