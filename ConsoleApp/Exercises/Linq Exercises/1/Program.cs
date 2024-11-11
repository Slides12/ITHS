// 1

var people = new[] { 
    new { FirstName = "Daniel",LastName = "Johansson", Age = 31, Height = 1.90, Weight = 89.5 },
    new { FirstName = "Samuel",LastName = "Karlsson", Age = 30, Height = 1.75, Weight = 75.3 }, 
    new { FirstName = "Fredrik",LastName = "Ahl", Age = 31, Height = 1.72, Weight = 70.0 }, 
    new { FirstName = "Christian",LastName = "Johansson", Age = 42, Height = 1.70, Weight = 75.0 }, 
    new { FirstName = "Annika",LastName = "Johansson", Age = 59, Height = 1.62, Weight = 65.0 }, 
    new { FirstName = "Per",LastName = "Koc", Age = 62, Height = 1.92, Weight = 99.5 },
    new { FirstName = "Sandra",LastName = "Johansson", Age = 34, Height = 1.60, Weight = 55.0 },
    new { FirstName = "Kerstin",LastName = "J", Age = 94, Height = 1.55, Weight = 45.0 },
    new { FirstName = "Carl",LastName = "P", Age = 12, Height = 1.55, Weight = 45.0 },

     };


// 2
//Method syntax
var newList = people.Where(x => x.Age >=20 && x.Age <=40).ToList();
//Query syntax
var newList01 = from p in people where p.Age >= 20 && p.Age <= 40 select p;


// 3
Console.WriteLine("\n**3**\n");
//Method syntax
if (newList.Where(x => x.Height > 1.90).Count() > 0)
{
    Console.WriteLine("Japp");
}
else
{
    Console.WriteLine("Nein");
}



// 4
Console.WriteLine("\n**4**\n");
//Method syntax
var newList2 = people
    .Where(p => p.FirstName.Count() > p.LastName.Count())
    .Select(p => new { FirstName = p.FirstName, LastName = p.LastName })
    .ToList();


//Query syntax
var newList02 = (from p in people
                where p.FirstName.Length > p.LastName.Length
                select new { FirstName = p.FirstName, LastName = p.LastName }).ToList();




// 5
Console.WriteLine("\n**5**\n");
//Method syntax
var newList3 = people
    .Select(p => new { Name = p.FirstName + " " + p.LastName, BMI =  Math.Round(p.Weight/(p.Height* p.Height),2)})
    .ToList();

//Query syntax
var newList03 = from p in people select new { Name = p.FirstName + " " + p.LastName, BMI = Math.Round(p.Weight / (p.Height * p.Height), 2) };



// 6
Console.WriteLine("\n**6**\n");
//Method syntax
newList3
    .Where(p => p.BMI > 25 || p.BMI < 20)
    .ToList()
    .ForEach(p => Console.WriteLine(p.Name));

//Query syntax
var bmiList = from p in newList03 where p.BMI > 25 || p.BMI < 20 select p;


// 7
Console.WriteLine("\n**7**\n");
//Method syntax
var people2 = people
    .Where(p => p.Weight / (p.Height * p.Height) > 25 || p.Weight / (p.Height * p.Height) < 20)
    .ToList();

//Query syntax
var people02 = from p in people where p.Weight / (p.Height * p.Height) > 25 || p.Weight / (p.Height * p.Height) < 20 select p;

// 8
Console.WriteLine("\n**8**\n");
//Method syntax
var newList4 = people
    .Select(p => new { Username = p.FirstName + p.Age, Category = p.Age >= 18 ? "Adult":"Child"})
    .ToList();

//Query syntax
var newList04 = from p in people select new { Username = p.FirstName + p.Age, Category = p.Age >= 18 ? "Adult" : "Child" };




// 10
Console.WriteLine("\n**10**\n");
    people
    .OrderBy(p => p.Height)
    .ToList()
    .ForEach(p => Console.WriteLine(p));


// 11
Console.WriteLine("\n**11**\n");
people
    .OrderByDescending(p => p.Age)
    .ToList()
    .ForEach(p => Console.WriteLine(p));

// 12
Console.WriteLine("\n**12**\n");
people
    .OrderBy(p => p.LastName)
    .ThenByDescending(p => p.LastName)
    .ToList()
    .ForEach (p => Console.WriteLine(p));

int totalsum = 0;

// 13
Console.WriteLine("\n**13**\n");
Enumerable
    .Range(1, 1_000_000_000)
    .AsParallel()
    .Where(i => i % 3 == 0 || i % 5 == 0)
    .ToList()
    .ForEach(i => AddNumber(i));


void AddNumber(int i)
{
    totalsum += i;
}

Console.WriteLine(totalsum);

