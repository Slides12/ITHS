Person per = new Person() { firstName = "Per", lastName = "Johansson" };
Person annika = new Person() { firstName = "Annika", lastName = "Johansson" };
Person myself = new Person() { firstName = "Daniel", lastName = "Johansson", father = per, mother = annika };




Console.WriteLine(myself.GetSelfAndParents());
Console.WriteLine(per.GetSelfAndParents());
Console.WriteLine(annika.GetSelfAndParents());




    



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
        string mothersName;
        string fathersName;


        if (this.father == null)
        {
            fathersName = "okänd";
        }
        else
        {
            fathersName = $"{father.firstName} {father.lastName}";
        }

        if(this.mother == null)
        {
            mothersName = "okänd";
        }
        else
        {
            mothersName = $"{mother.firstName} {mother.lastName}";

        }
        return $"{GetFullName()} Mamma: {mothersName}  Pappa: {fathersName}";
    }
}
