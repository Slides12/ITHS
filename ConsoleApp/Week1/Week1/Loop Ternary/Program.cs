int x = 6;
bool i = true;


if (x <= 7)
{
    if (x == 7)
    {
        Console.WriteLine("Tja");
    }
    else if (i)
    {
        Console.WriteLine("Hej");

    }

    Console.WriteLine("Synd");

}






Console.WriteLine(true ? "Japp!" : "nope");

x = 15;

int y = (x < 10 ? 5 : 8);


int numberOfPeople = 5;
Console.WriteLine($"{numberOfPeople} person{(numberOfPeople == 1 ? "" : "er")}");



switch (x)
{
    case 15:
        Console.WriteLine("hejhej");
        break;
}