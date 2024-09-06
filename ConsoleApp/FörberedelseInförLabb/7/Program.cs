string userInput = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string findString = "chuck"; // hur fan hittar jag denna?
int foundIndex = userInput.IndexOf(findString,0);
int currentIndexOutOfFound = 0;

for (int i = 0; i < userInput.Length; i++) { 

    if(currentIndexOutOfFound == findString.Length)
    {
        foundIndex = userInput.IndexOf(findString, foundIndex+1);
        currentIndexOutOfFound = 0;

    }

    if (i >= foundIndex && i <= foundIndex+findString.Length)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        currentIndexOutOfFound++;

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;

    }

    Console.Write(userInput[i]);

}
