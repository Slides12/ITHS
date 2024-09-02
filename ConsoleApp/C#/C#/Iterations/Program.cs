int x = 0;

while (x < 3)
{
    x++;
    Console.WriteLine("Hej");
}



do
{
    x++;

    Console.WriteLine("Hej");
} while (x < 4);






for(int i = 0;i < 10;i++)
{
    if (i == 5)
    {
        Console.WriteLine(i);

        continue;

    }

    if (i == 8)
    {
        Console.WriteLine(i);
        break;

    }
}



for (int i = 0; i < 10; i++)
{
    Console.Write("Hej");
    for (int j = 0; j < 1; j++)
    {
        Console.Write(" Då \n");
    }
}

