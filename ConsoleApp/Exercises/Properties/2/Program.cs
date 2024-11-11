



class Person
{
    private string _firstName;

    public string LastName{ get; set; }

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

}