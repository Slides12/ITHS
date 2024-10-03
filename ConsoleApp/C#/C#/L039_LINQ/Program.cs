using L037__Library;

List<object> objectList = new List<object>();

objectList.Add("Hello");
objectList.Add("world");
objectList.Add(5);
objectList.Add("Hej");
objectList.Add(true);
objectList.Add(3.4);
objectList.Add("Bye!");



Console.WriteLine("***EJ LINQ***");


List<string> stringList = new List<string>();

foreach (object item in objectList)
{
    if (item is string s)
    {
        stringList.Add(s);
    }
}





Console.WriteLine("***LINQ***");




var stringList2 = objectList.OfType<string>().ToList();


Console.WriteLine(stringList2.Any(s => s.StartsWith('B')));
Console.WriteLine("stringList2 content:");
Console.WriteLine(string.Join('\n', stringList2));
Console.WriteLine();

Console.WriteLine($"{"stringList2.Any(s => s.Length == 5)",-50} {stringList2.Any(s => s.Length == 5)}");
Console.WriteLine($"{"stringList2.All(s => s.Length <= 10)",-50} {stringList2.All(s => s.Length <= 10)}");
Console.WriteLine($"{"stringList2.Any(s => s == \"Hej\")",-50} {stringList2.Any(s => s == "Hej")}");
Console.WriteLine($"{"stringList2.Any(s => s.Contains(\"ye\"))",-50} {stringList2.Any(s => s.Contains("ye"))}");
Console.WriteLine($"{"stringList2.Any(s => s.ToLower() == \"hej\")",-50} {stringList2.Any(s => s.ToLower() == "hej")}");
Console.WriteLine($"{"stringList2.Any(s => s.Split(' ').Length == 3)",-50} {stringList2.Any(s => s.Split(' ').Length == 3)}");
Console.WriteLine($"{"stringList2.All(s => s.StartsWith('B'))",-50} {stringList2.All(s => s.StartsWith('B'))}");



Console.WriteLine();
Console.WriteLine("******************************");
Console.WriteLine();

var stringList3 = stringList2.Where(s => s.Length == 5).ToList();
Console.WriteLine("stringList3 content:");
Console.WriteLine(string.Join('\n', stringList3));

Console.WriteLine("\n****************************************\n");

var people = new[]
{
    new {LasttName = "Eriksson", FirstName = "Anders", Age = 39 },
    new {LasttName = "Palm", FirstName = "Lisa", Age = 40 },
    new {LasttName = "Andersson", FirstName = "Per", Age = 31 },
    new {LasttName = "Lundberg", FirstName = "Anna", Age = 66 },
    new {LasttName = "Eriksson", FirstName = "Camilla", Age = 65 },

}.ToList();


var people2 = people
    .Where(p => p.Age >= 40)
    .Select(p => new {
        FirstName = p.FirstName.Title(), 
        Age = p.Age})
    .ToList();


Console.WriteLine();

people2.ForEach(p => Console.WriteLine(p.FirstName));


Console.WriteLine("\n*********Query Syntax**********\n");


var query = from p in people where p.Age >= 40 select p.Age;
//var methodSyntax = people.Where(p => p.Age >= 40).Select(p => p);


foreach (var age in query)
{
    Console.WriteLine(age);
}

Console.WriteLine("\nAdd person to people\n");
people.Add(new { LasttName = "Eriksson", FirstName = "Camilla", Age = 45 });
foreach (var age in query)
{
    Console.WriteLine(age);
}