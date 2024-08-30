Console.WriteLine("Skriv ett ord: ");

string userInput = Console.ReadLine();

char[] userInputArry = userInput.ToLower().ToCharArray();

char[] reverseArray = new char[userInputArry.Length];

int x = userInputArry.Length;   

for(int j = 0; j < userInputArry.Length; j++)
{
    x--;

    reverseArray[j] = userInputArry[x];
}

for (int i = 0; i < userInputArry.Length; i++)
{
    if(userInputArry[i] == reverseArray[i])
    {
        Console.WriteLine($"{userInput} är fan en palindrom.");
        break;
    }
    else
    {
        Console.WriteLine("Ingen palindrom.");
        break;
    }
}