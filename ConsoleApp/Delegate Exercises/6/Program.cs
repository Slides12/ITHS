

Delegate32((s1,s2) => $"firstName has {s1.Length} letters, lastName has {s2.Length} letters.");




string DelegateType(string firstName, string lastName)
{
    return firstName + " " + lastName;
}



string DelegateType2(string firstName, string lastName)
{
    return $"firstName: {firstName}\nlastName: {lastName}";
}


void Delegate32(Func<string, string, string> demoDelegate)
{
    Console.WriteLine(demoDelegate.Invoke("Daniel", "Johansson\n"));
    Console.WriteLine(demoDelegate.Invoke("Kurt", "Svensson\n"));
    Console.WriteLine(demoDelegate.Invoke("Din", "mamma\n"));

}
