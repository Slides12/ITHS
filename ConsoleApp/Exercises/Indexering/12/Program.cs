﻿Console.WriteLine("Mata in en text: ");

string userInput = Console.ReadLine();

Console.WriteLine("Mata in en bokstav: ");

string userInput1 = Console.ReadLine();

int x = 0;


foreach(char c in userInput)
{
   

    if (c.ToString() == userInput1)
    {
        x++;
    }

    if(x % 2 != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write(c);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write(c);
    }



}