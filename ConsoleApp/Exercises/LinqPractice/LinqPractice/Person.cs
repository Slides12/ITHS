// See https://aka.ms/new-console-template for more information


class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


    public override string ToString()
    {
        return $"{Name} {LastName}, {Age} år.";
    }
}