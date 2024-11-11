

Person person = new Person() {FirstName ="Daniel", LastName = "Johansson" };

Console.WriteLine(person.FullName);





class Person
{
    private string _firstName;

    public string LastName { get; set; }

    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }


    public string FullName
    {
        get 
        {
            return $"{FirstName} {LastName}";
        }
    }

}