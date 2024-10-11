
MyDelegate myDelegate = new MyDelegate(DelegateType);


Console.WriteLine(myDelegate.Invoke("Hej pså dig", "Morsan"));

string DelegateType(string firstName, string lastName)
{
    return firstName + " " + lastName;
}

public delegate string MyDelegate(string firstName, string lastName);
