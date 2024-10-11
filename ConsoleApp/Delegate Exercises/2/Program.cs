

Func<string, string, string> myDelegate = DelegateType;

Console.WriteLine(myDelegate.Invoke("Hej på dig", "Morsan"));

string DelegateType(string firstName, string lastName)
{
    return firstName + " " + lastName;
}

