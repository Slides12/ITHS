


Cat myCat = new Cat("Pelle");
Cat myOtherCat = new Cat() {name = "Pelle Svanslös" };
Cat myThirdCat = new Cat(8);


Console.WriteLine(myCat.name + myCat.age);



class Cat 
{
    public string name = "Misse";
    public int age = 0;


    public Cat()
    {
        Console.WriteLine($"Skapade en katt! Hen heter {name}");
    }

    public Cat(string name)
    {
        this.name = name;
        Console.WriteLine($"Skapade en katt! Hen heter {name}");

    }

    public Cat (int n)
    {
        this.name = "";
        for (int i = 0; i <= n; i++)
        {
            this.name += i;
            Console.WriteLine(this.name);
        }
    }

    public Cat(string name,int n)
    {
        this.name = name;
        this.age = n;
    }

}