

List<string> countries = new List<string>() {"france","spain","italy" };

//countries.Clear();


countries.Add("sweden");
countries.Add("norway");

//countries.Remove("italy");
//countries.RemoveAt(3);
//countries.RemoveRange(1, 3);


foreach (var country in countries)
{
    Console.WriteLine(country);
}


var myCountry = "sweden";
Console.WriteLine(countries.Contains(myCountry));





string[] myCountries = countries.ToArray();

Array.Resize(ref myCountries, 10);


Console.WriteLine();

List<int> numbers = new List<int>();

for (int i = 0;i < 40; i++)
{
    numbers.Add(i);
    Console.WriteLine($"{numbers.Count} , {numbers.Capacity}");
}

