

int a = 5;
int b = a;
a = 3;


Console.WriteLine($"a = {a}, b = {b}");

Console.WriteLine();

Cat catA = new Cat() {name = "Pelle" };
Cat catB = catA; //Pekar på heapen på samma minne som catA. Reference type.
catA.name = "Måns";

Console.WriteLine($"catA = {catA.name}, catB = {catB.name}");

Console.WriteLine();

PassValueTypeByValue(a);
Console.WriteLine($"after PassValueTypeByValue(a) => a = {a}");

PassValueTypeByReference(ref a);
Console.WriteLine($"after PassValueTypeByReference(a) => a = {a}");


static void PassValueTypeByValue(int i)
{
    i = 0;
    //Console.WriteLine(i);
}


static void PassValueTypeByReference(ref int i)
{
    i = 0;
    //Console.WriteLine(i);
}

Console.WriteLine();


PassReferenceTypeByValue(catA);
Console.WriteLine($"after PassReferenceTypeByValue(catA) => catA.name = {catA.name}");

PassReferenceTypeByReference(ref catA);
Console.WriteLine($"after PassReferenceTypeByReference(ref catA) => catA.name = {catA.name}");

static void PassReferenceTypeByValue(Cat cat)
{
    cat = new Cat() {name ="Bosse" };
    //cat.name = "Bosse";


    //Console.WriteLine(cat.name);
}



static void PassReferenceTypeByReference(ref Cat cat)
{
    cat = new Cat() { name = "Bosse" };
    //cat.name = "Bosse";


    //Console.WriteLine(cat.name);
}



class Cat() 
{
    public string name;
}