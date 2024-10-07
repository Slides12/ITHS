// See https://aka.ms/new-console-template for more information

using LinqPractice;


List<Employee> employees = new Employees().EmployeeList;



// Where. Where används för att filtrera ut data ut en samling.
// Syntaxen är lista.Where(x => x.Age > 30);
//I exemplet ovan filtrerar vi ut alla personer som är äldre än 30 år.


//Övningar med Where

//1. filtrera ut alla personer som är äldre än 30 år och skriv ut listan till konsollen.

//employees
//    .Where(e => e.Age > 30)
//    .ToList()
//    .ForEach(e => Console.WriteLine(e));

//2. filtrera ut alla personer som jobbar på avdelningen "Engineering" och skriv ut listan till konsollen.

//employees
//    .Where(e => e.Department =="Engineering")
//    .ToList()
//    .ForEach (e => Console.WriteLine(e));

//3. filtrera ut alla personer som har en lön över 70000 och skriv ut listan till konsollen.

//employees
//    .Where(e => e.Salary > 70_000)
//    .ToList()
//    .ForEach(e => Console.WriteLine(e));

//4. filtrera ut alla personer som har en lön över 70000 och är äldre än 30 år och skriv ut listan till konsollen.

//employees
//    .Where(e => e.Salary > 70_000 && e.Age > 30)
//    .ToList()
//    .ForEach(e => Console.WriteLine(e));


// OrderBy. OrderBy används för att sortera data.
// Syntaxen är lista.OrderBy(x => x.Age);
// I exemplet ovan sorterar vi listan efter ålder.
// Om vi vill sortera i fallande ordning använder vi OrderByDescending.

//Övningar med OrderBy


//1. Sortera listan efter namn och skriv ut listan till konsollen.

//employees
//    .OrderBy(e => e.Name)
//    .ToList()
//    .ForEach(e =>  Console.WriteLine(e));


//2. Sortera listan efter avdelning och skriv ut listan till konsollen.

//employees
//    .OrderBy (e => e.Department)
//    .ToList()
//    .ForEach (e =>  Console.WriteLine (e));


//3. Sortera listan efter lön och skriv ut listan till konsollen.

//employees
//    .OrderBy(e => e.Salary)
//    .ToList()
//    .ForEach(e =>  Console.WriteLine(e));



//4. Sortera listan efter ålder i fallande ordning och skriv ut listan till konsollen.

//employees
//    .OrderByDescending(e => e.Age)
//    .ToList()
//    .ForEach(e =>  Console.WriteLine(e));


// Select. Select används för att projicera data.
// Syntaxen är lista.Select(x => x.Name);
// I exemplet ovan projicerar vi ut alla namn från listan. Vi får då tillbaka en IEnumerable<string> med alla namn.


//Övningar med Select

//1. Skapa en lista av strängar med alla namn och skriv ut till konsollen.

//employees
//.Select(e => e.Name)
//.ToList()
//.ForEach(e =>  Console.WriteLine(e));

//2. Skapa en lista av strängar med alla avdelningar och skriv ut till konsollen.

//employees
//.Select(e => e.Department)
//.ToList()
//.ForEach(e => Console.WriteLine(e));

//3. Skapa en lista av ints med alla åldrar.

//employees
//    .Select(e => e.Age)
//    .ToList()
//    .ForEach(e => Console.WriteLine(e));

//4. AVANCERAD:
//Skapa en klass som heter Person med properties för Name, LastName och Age.
//Skapa en lista av Person-objekt och fyll den med relevant data från Employee-objekten.

List<Person> people = new List<Person>();

people.Add(new Person() { Name = "Daniel", LastName = "Johansson", Age = 30 });
people.Add(new Person() { Name = "Annika", LastName = "Johansson", Age = 59 });
people.Add(new Person() { Name = "Per", LastName = "Johansson", Age = 62 });
people.Add(new Person() { Name = "Sandra", LastName = "Johansson", Age = 34 });
people.Add(new Person() { Name = "Charlotte", LastName = "Karlsson", Age = 28 });
people.Add(new Person() { Name = "Sandra", LastName = "Karlsson", Age = 44 });
people.Add(new Person() { Name = "Ebba", LastName = "Simonsson", Age = 22 });
people.Add(new Person() { Name = "Fredrik", LastName = "Karlsson", Age = 25 });
people.Add(new Person() { Name = "Magnus", LastName = "Ivarsson", Age = 37 });
people.Add(new Person() { Name = "Liselotte", LastName = "Johnsson", Age = 52 });
people.Add(new Person() { Name = "Hans", LastName = "Macintosh", Age = 21 });
people.Add(new Person() { Name = "Anna", LastName = "Sturesson", Age = 27 });
people.Add(new Person() { Name = "Anja", LastName = "Andersson", Age = 39 });
people.Add(new Person() { Name = "Märta", LastName = "Pettersson", Age = 66 });
people.Add(new Person() { Name = "Kevin", LastName = "Karlsson", Age = 72 });
people.Add(new Person() { Name = "Julius", LastName = "Samuelsson", Age = 12 });





//Linq metoder går att länka ihop. Detta gör att vi kan skriva flera metoder efter varandra.
//Exempel: lista.Where(x => x.Age > 30).OrderBy(x => x.Name);
//I exemplet ovan filtrerar vi ut alla personer som är äldre än  30 år och sorterar dem efter namn.


//Övningar med flera metoder


//1. Filtrera ut alla personer som är äldre än 30 år och sortera dem efter namn. Skriv ut listan till konsollen.

//people
//    .Where(p => p.Age > 30)
//    .OrderBy(p => p.Name)
//    .ToList()
//    .ForEach(p => Console.WriteLine(p));

//2. Filtrera ut alla personer som jobbar på avdelningen "Engineering" och sortera dem efter lön. Skriv ut listan till konsollen.

//employees
//    .Where(e => e.Department == "Engineering")
//    .OrderBy(e => e.Salary)
//    .ToList()
//    .ForEach(p => Console.WriteLine(p));

//3. Filtrera ut alla personer som har en lön över 70000 och sortera dem efter ålder. Använd därefter select för att skapa en lista av strängar som innehåller namn och lön. Skriv ut listan till konsollen.


//employees
//    .Where(e => e.Salary > 70_000)
//    .OrderBy(e => e.Age)
//    .ToList()
//    .ForEach (p => Console.WriteLine(p));


//4. AVANCERAD:
//Skapa en klass som heter Engineers med properties som du tycker är relevanta.
//Filtrera ut alla personer som jobbar på avdelningen "Engineering" och skapa en lista av Engineers-objekt som är sorterad efter ålder i fallander ordning. Skriv ut listan till konsollen.

List<Engineers> engineers = new List<Engineers>();

    employees
    .Where(e => e.Department == "Engineering")
    .ToList()
    .ForEach(e => 
    engineers.Add(new Engineers {Name = e.Name,
    LastName = e.LastName,
    Age = e.Age,
    Salary = e.Salary}));


engineers.ForEach (e => Console.WriteLine(e));


Console.WriteLine();