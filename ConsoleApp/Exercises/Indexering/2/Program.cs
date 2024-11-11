string[] test = new string[10] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
int x = 0;
string userInput = "";
Console.WriteLine("Skriv en siffra: ");


userInput = Console.ReadLine();

if(int.TryParse(userInput, out int y))
{
    x = y;
    Console.WriteLine(test[x]);

}
else
{
    Console.WriteLine("En siffra måste du skriva, testa igen. \n");
}

