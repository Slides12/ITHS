string userInput = "Hello world";


for (int i = 0; i < userInput.Length; i++)
{
    
    if (i < userInput.Length-1) 
    {
        if (userInput[i] == userInput[i + 1])
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(userInput[i]);
            continue;

        }
        else if (i != 0)
        {
            if (userInput[i] == userInput[i - 1])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(userInput[i]);
                continue;
            }
        }

    }
    else if(i == userInput.Length) 
    {
        if (userInput[i] == userInput[i - 1])
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(userInput[i]);
            continue;
        }
    }
   
    
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(userInput[i]);
    

}

