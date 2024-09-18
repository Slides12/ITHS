Person p1 = new Person();
Person p2 = new Person();
Person p3 = new Person();


p1.firstName = "Peter";
p1.lastName = "Svensson";
p2.firstName = "Yngve";
p2.lastName = "Pettersson";

Console.WriteLine($"{p1.firstName} {p1.lastName}");
Console.WriteLine($"{p2.firstName} {p2.lastName}");
Console.WriteLine($"{p3.firstName} {p3.lastName}");

Console.WriteLine(p2.GetFullName("Mr."));
Console.WriteLine(p2.GetFullNameReversed());







class Person
{
    public string firstName = "Default";
    public string lastName = "Defaultsson";


    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }
    public string GetFullName(string title)
    {
        return $"{title} {this.firstName} {this.lastName}";
    }

    public string GetFullNameReversed()
    {
        char[] chars = GetFullName().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
