Person per = new Person() {firstName = "Per", lastName = "Johansson" };
Person annika = new Person() { firstName = "Annika", lastName = "Johansson" };
Person myself = new Person() { firstName = "Daniel", lastName = "Johansson", father = per, mother = annika };




Console.WriteLine(myself.GetSelfAndParents());








class Person
{
    public string firstName = "Default";
    public string lastName = "Defaultsson";
    public Person mother;
    public Person father;




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

    public string GetSelfAndParents()
    {

        return $"{GetFullName()} Mamma: {mother.GetFullName()}  Pappa: {father.GetFullName()}" ;
    }
}
