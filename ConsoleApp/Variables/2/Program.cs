int x;
int y;
string z = "";
while (true) { 
Console.WriteLine("Skriv in första talet: ");

z = Console.ReadLine();

//Try parse ger ett bool värde om det lyckas att omvandla x till en siffra. True/False.
if(Int32.TryParse(z, out x)) { 
x = Int32.Parse(z);
}
else
{
    Console.WriteLine("Siffra, inte text. Testa igen");
        break;

    }
    Console.WriteLine("Skriv in andra talet: ");

z = Console.ReadLine();
if (Int32.TryParse(z, out y))
{

    y = Int32.Parse(z);
}
else
{
    Console.WriteLine("Siffra, inte text. Testa igen");
        break;
}
    Console.WriteLine($"{x} * {y} = {x * y}");
    break;


}
