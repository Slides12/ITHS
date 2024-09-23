
//var animal = new Animal() { Name = "Heffa Klump" };

//animal.Run();
using System.Xml.Linq;

Console.WriteLine();

Cat cat = new Cat() {Name = "Pelle"};

cat.Run();
cat.Mew();
cat.Walk();

Console.WriteLine();
Dog dog = new Dog() { Name = "Fido" };
dog.Run();
dog.Bark();
dog.Walk(); // Ärver Walk från Animal

Console.WriteLine();

Animal[] animals = new Animal[] //Kan även vara object[] animals = new object[]
{
    new Cat() {Name = "Pelle" },
    new Dog() {Name = "Fido"},
    new Dog() {Name = "Bosse"},
    new Cat() {Name = "Måns" }

};

foreach (Animal animal in animals)
{
    animal.Run();
    animal.Walk();
    (animal as Dog)?.Bark();
    (animal as Cat)?.Mew();


    if (animal is Dog dog1)
    {
        dog.Bark();
        (animal as Dog).Bark();
    }
    else if (animal is Cat cat1)
    {
        cat.Mew();
    }
    Console.WriteLine();

}



Char myChar = 'A';
Console.WriteLine((int)myChar);


Console.WriteLine();

Animal myAnimal = new Cat() {Name = "Pelle" };
Cat myCat = (Cat)myAnimal;
myCat.Mew();



abstract class Animal
{
    required public string Name { get; set; }

    public abstract void Run();

    public virtual void Walk()
    {
        Console.WriteLine($"{Name} is walking!");
    }
}




class Cat : Animal
{

    
    public void Mew()
    {
        Console.WriteLine($"{Name} is Meowing!");
    }

    public override void Run()
    {
        Console.WriteLine($"The cat {Name} is running!");
    }

    public override void Walk()
    {
        Console.WriteLine($"{Name} is walking like a Cat!");
    }
}


class Dog : Animal
{
    
    public void Bark()
    {
        Console.WriteLine($"{Name} is Barking!");
    }

    public override void Run()
    {
        Console.WriteLine($"The dog {Name} is running!");

    }

    
}