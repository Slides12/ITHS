﻿string userInputHeight = "";
string userInputWidght = "";

int x = 0;
int y = 0;
while (true)
{
Console.WriteLine();
Console.WriteLine("Mata in höjd: ");
userInputHeight = Console.ReadLine();

    if (int.TryParse(userInputHeight, out x))
    {
        x = int.Parse(userInputHeight);
    }
    else
    {
        Console.WriteLine("Inte en siffra. Testa igen.");
        continue;
    }



Console.WriteLine("Mata in bredd: ");
userInputWidght = Console.ReadLine();


    if (int.TryParse(userInputWidght, out y))
    {
        y = int.Parse(userInputWidght);
    }
    else
    {
        Console.WriteLine("Inte en siffra. Testa igen.");
        continue;
    }


    for (int i = 1;i <= x; i++)
{
    Console.WriteLine();
    for(int j = 1;j <= y; j++)
    {
        Console.Write("x");
    }
}
}
