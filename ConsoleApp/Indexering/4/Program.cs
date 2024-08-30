Console.WriteLine("Skriv något: ");

string userInput = Console.ReadLine();

char[] userInputArray = userInput.ToLower().ToCharArray();

char[] vokaler = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä','ö' };

for (int i = 0; i < userInputArray.Length; i++)
{
    foreach(char c in vokaler)
    {
        if (userInputArray[i] == c)
        {
            userInputArray[i] = '*';
        }
    }
}    

foreach(char c in userInputArray)
{
    Console.Write(c);
}


