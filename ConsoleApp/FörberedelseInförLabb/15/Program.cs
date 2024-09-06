Console.WriteLine("Skriv en valfri sträng: ");

string userInput = Console.ReadLine();



for (int i = 0; i < userInput.Length; i++)
{
    for(int j = 0;j < userInput.Length; j++) 
    { 
        if(j >= i && j <= userInput.IndexOf(userInput[i],i+1))
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {

            Console.ForegroundColor = ConsoleColor.White;
        }
    Console.Write(userInput[j]);
    }
    Console.WriteLine();
}