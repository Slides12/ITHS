string userInput = "";

Console.WriteLine("Mata in en sträng: ");

userInput = Console.ReadLine();

foreach(char letter in userInput)
{
    Console.WriteLine(letter);
}
