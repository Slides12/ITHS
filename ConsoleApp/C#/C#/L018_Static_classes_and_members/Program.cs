Cat myCat = new Cat() {name = "Pelle" };

//Cat.name = "Daniel";
myCat.Greet();
//Cat.Hello();

Cat.PrintNumberOflIves();





// Om klassen i sig är static kan man inte instancera object alls. T.ex Console myConsole = new Console();

class Cat 
{
    public string name;
    public static int numberOfLives = 9;
    public void Greet()
    {
        Console.WriteLine($"Hi, my name is {name} and i have {numberOfLives} lives.");
    }

    public static void PrintNumberOflIves()
    {
        Console.WriteLine($"Every cat has {numberOfLives} lives.");
    }

}

