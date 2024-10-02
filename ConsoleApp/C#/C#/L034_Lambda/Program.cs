
//Func<int, int> square1 = Square;
using System;

Func<int, int> square = x => x*x;

Action<int>PrintInt = x => Console.WriteLine(x);


//Console.WriteLine(Square(5)); // Funktion med namn

Console.WriteLine(square(5)); // Lambda

PrintInt(square(5));

Console.WriteLine();

Func<Person, int, bool> isLegal = (person, legalAge) => person.Age >= legalAge;

Console.WriteLine(isLegal(new Person() { Age = 15 }, 18));
Console.WriteLine("******************************");


PrintResult(x => x*x + x);


static void PrintResult(Func<int, int> func)
{
    for (int i = 0; i < 10;i++)
    {
        Console.WriteLine($"{i}: {func(i)}");

    }
}


//static int Square(int a)
//{
//    return a * a;
//}

class Person
{
    public int Age { get; set; }
}