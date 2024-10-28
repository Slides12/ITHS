using System.Text.Json;
using System.Text.Json.Serialization;

var data = new[] {
    new { FirstName = "Kalle", LastName = "Andersson", Length = 182 },
    new { FirstName = "Emma", LastName = "Andersson", Length = 172 }
};

var options = new JsonSerializerOptions() { 
    WriteIndented = true,
    IncludeFields = true,
    IgnoreReadOnlyFields = false,
    AllowTrailingCommas = true,
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

var people = new List<Person>()
{
    new Person("Kalle", "Andersson", true, 182, 85),
    new Person("Emma", "Andersson", false, 172,72),

};

people[0].BestFriend = people[1];

string json = JsonSerializer.Serialize(people, options);


Console.WriteLine(json);


//File.WriteAllText("C:\\Users\\djoha\\Desktop\\demo.json", json);


//string json = File.ReadAllText("C:\\Users\\djoha\\Desktop\\demo.json");

//Console.WriteLine(json);

//var options = new JsonSerializerOptions() { 
//    UnmappedMemberHandling =System.Text.Json.Serialization.JsonUnmappedMemberHandling.Disallow

//};

//var people = JsonSerializer.Deserialize<List<Person>>(json);


class Person
{
    public readonly double weight;

    public Person(string firstName, string lastName, bool isStudent, double length, double weight)
    {
        FirstName = firstName;
        LastName = lastName;
        IsStudent = isStudent;
        Length = length;
        this.weight = weight;
    }

    public string FirstName { get; set; }

    [JsonIgnore]
    public string LastName { get; set; }

    [JsonPropertyOrder(-1)]
    [JsonPropertyName("ThiIsAStudent")]
    public bool IsStudent { get; set; }
    public double Length { get; set; }

    public Person BestFriend { get; set; }

}