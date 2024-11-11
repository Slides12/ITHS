string[] strings = new string[7];

int x = strings.Length;

Console.WriteLine("Skriv ett ord: ");


for (int i = 0; i < strings.Length; i++)
{
    string userInput = Console.ReadLine();

    strings[i] = userInput;
    Console.WriteLine("Skriv ett ord till: \n");

}

foreach (string s in strings)
{
    x--;
    Console.WriteLine(strings[x]);
}