Console.WriteLine("A");
Console.WriteLine("B");
Console.WriteLine("C");
Console.WriteLine("D");
Console.WriteLine("E");
Console.WriteLine("F");
Console.WriteLine("G");


int x = 0;
int y = 0;

while (x < 10)
{
    Console.WriteLine($"x = {x}, y = {y}");
    x++;
    if (x % 2 == 0) y++;
}