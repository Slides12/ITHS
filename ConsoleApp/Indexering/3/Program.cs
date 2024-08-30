string userInput = "";

Console.WriteLine("Skriv något!");

userInput = Console.ReadLine();
char[] userInputArray =userInput.ToCharArray();
int x = userInputArray.Length;

for (int i = 0; i < userInputArray.Length; i++)
{
    x--;
    Console.Write(userInputArray[x]);
    
}