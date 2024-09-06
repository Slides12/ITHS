string userInput = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string findString = "oo"; // hur fan hittar jag denna?

for (int i = 0; i < userInput.Length; i++)
{

   if (userInput[i] == 'o' && userInput[i+1] == 'o')
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(userInput[i]);
    }
   else if (userInput[i] == 'o' && userInput[i - 1] == 'o')
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(userInput[i]);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(userInput[i]);

    }

}