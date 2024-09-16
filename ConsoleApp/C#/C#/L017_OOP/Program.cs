Cat myCat = new Cat() { name = "Misse", age = 3 }; // Instancering
Cat myOtherCat = new Cat() { name = "Pelle", age = 5 };
Cat myThirdCat = new Cat() { name = "Sven", age = 12 };

// Cat myOtherCat = myCat;  (pekar på samma katt.);

Cat[] cats = new Cat[] { myCat, myOtherCat, myThirdCat, new Cat() { name = "Orvar", age = 77 } };



// Mini uppgift: 

Cat[] hundredCats = new Cat[100];


for (int i = 0; i < 100; i++)
{
    hundredCats[i] = new Cat() { name = $"Katt{i}", age = i };
    Console.WriteLine();
}

foreach (Cat c in hundredCats)
{
    Console.WriteLine($" {c.name} är {c.age} år gammal.");
    Console.WriteLine(c.GetDoubleAge());
}

public class Cat
{
    public string name = "Default name.";
    public int age = 0;



    public void Greet()
    {
        Console.WriteLine($"Hej, jag heter {name}!");
    }
    public void Greet(string name)
    {
        Console.WriteLine($"Hej, jag heter {name}!");
    }
    public void Greet(Cat katt)
    {
        Console.WriteLine($"Hej, jag heter {katt.name}!");
    }
    public int GetDoubleAge()
    {
        return age * 2;
    }
}

