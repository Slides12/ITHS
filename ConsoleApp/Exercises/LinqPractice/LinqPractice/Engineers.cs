// See https://aka.ms/new-console-template for more information


class Engineers
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    public override string ToString()
    {
        return $"{Name} {LastName} {Age} år, tjänar: {Salary} kr i månaden.";
    }
}