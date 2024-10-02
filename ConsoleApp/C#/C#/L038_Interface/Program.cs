﻿
Dog[] dogs =
{
    new Dog() {Name = "Fido", Age = 4 },
    new Dog() {Name = "Karo", Age = 6 },
    new Dog() {Name = "Bob", Age = 9 },
    new Dog() {Name = "Kaj", Age = 3 },
    new Dog() {Name = "Lajka", Age = 1 },

};

Array.Sort(dogs);


using (var dog = new Dog())
{
    //Läs fil
    Console.WriteLine("Dog");
}
Console.WriteLine("The end");


List<IDog> list = new List<IDog>() {new Animal(), new Dog() };

int[] ints = { 5, 6, 2, 5, 1, 3, -1 };


class Animal : IDog
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Dog : IDisposable, IDog, IComparable<IDog>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(IDog? other)
    {
        return this.Age.CompareTo(other.Age);
    }

    public void Dispose()
    {
        Console.WriteLine("Disposed!");
    }

    public override string ToString()
    {
        return $"Name = {Name}, Age = {Age}";
    }
}

interface IDog
{
    public string Name { get; set; }
    public int Age { get; set; }

}