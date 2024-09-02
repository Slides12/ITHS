
static void MyFunction()
{
    for(int i = 0; i < 10; i++)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}


static void FunctionA()
{
    Console.WriteLine("Här startar funktion A");
    Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAA");
    Console.WriteLine("Här slutar funktion A");

}
static void FunctionB()
{
    Console.WriteLine("Här startar funktion B");
    FunctionA();

    Console.WriteLine("Här slutar funktion B");
}
//FunctionB();
//FunctionA();
//FunctionB();




int x = 3;

static void MyFunction1(int a, int b, string s ="Default value")
{
    Console.WriteLine(a + b);
    Console.WriteLine(s);
    Console.WriteLine();

}

MyFunction1(8,2,"Hello");
MyFunction1(6,x, "World");
MyFunction1(x,x);


// Miniuppgift 1 & 2

static void Greet(string namn, int gånger = 1) {
    for (int i = 0; i < gånger; i++)
    {
        Console.WriteLine($"Hej {namn}");
    }
}

Greet("Daniel",10);


Console.WriteLine("*****************");

static string GetFullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";

}

string fullName = GetFullName("Daniel", "Johansson");
    Console.WriteLine(GetFullName("Daniel", "Johansson"));

Console.WriteLine(fullName.ToUpper());


//Naming arguments
Console.WriteLine(GetFullName(firstName: "Dj", lastName: "ahrå"));


Console.WriteLine("**************************************");

//Keyword: Params

static void PrintStrings(params string[] strings)
{
    for (int i = 0; i < strings.Length; i++)
    {
        Console.WriteLine(strings[i]);
    }
}


string[] names = new string[] { "Kalle", "Niklas", "Anna", "Frida" };

PrintStrings(names);
Console.WriteLine("************************");
PrintStrings("Kalle", "Niklas", "Anna", "Frida" );