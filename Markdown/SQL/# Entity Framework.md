# Entity Framework



## Access/Create the database
```C#
internal class DemoContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = new SqlConnectionStringBuilder()
        {
            ServerSPN = "localhost",
            InitialCatalog = "DemoDB",
            TrustServerCertificate = true,
            IntegratedSecurity = true,
        }.ToString();

        optionsBuilder.UseSqlServer(connectionString);
    }
}
```

* DbSet<Student> är för att lägga till kolumner i databasen-

* Koden ovan skapar även en ny Databas, iom att DemoDB inte finns. Använd en som existerar för att koppla mot den.

* Localhost kan även vara IP.


* db.Database.EnsureDeleted(); Ser till så att databasen du angett i InitialCatalog finns, om den inte gör det så skapar den i det namn som står.

* db.Database.EnsureCreated(); Tar bort det som står i InitialCatalog.

## Set primary keys / foreign keys

```C#
public class Student
{
    public int StudentId { get; set; }

    public required string FirstName { get; set; }
    public string? LastName { get; set; }

    public DateOnly? DateOfBirth { get; set; }
}
```
* Lägg sätt en prop till Id för att få en primary key, du kan även använda classens namn med Id i slutet för att göra det till en primary key. (Blir automatiskt Identity (1,1))

* Foreign key gör du genom  att göra en prop till en Lista av korrekt typ.

* För att göra den nullable, sätt ett "?" efter typen i C# koden.

* Required i C# gör så att kompilatorn ger fel meddelande direkt innan det kompileras, om det inte sätts så ger databasen ett error senare. 

## Different unique types

* Guid 
```C#
public Guid StudentId { get; set; } = Guid.NewGuid();
```

* Normalt unik, t.ex ISBN

* Identity (1,1)


## How to ensure database exists and add data into

```C#
using var db = new DemoContext();
db.Database.EnsureDeleted();
db.Database.EnsureCreated();


var student = new Student() {FirstName = "Anders" };

db.Students.Add(student);
db.SaveChanges();
```

* db.SaveChanges behövs för att spara data i databasen. (Körs inte denna så sparas ej datan.)



## Fluent - API / Annotations
Fluent - API
```C# 
// Byt namn på table
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Student>().ToTable("IthsStudents");
}
```

* Det ovan är Fluent api, det görs i OnModelCreating samt går före Annotations.

```C# 
// Byt namn på table och SCHEMA
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Student>().ToTable("IthsStudents", "ITHS");
}
```
```C#
 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     modelBuilder.Entity<Student>().ToTable("IthsStudents", "ITHS");
        // ignore tar bort specifika kolumner i student.
     modelBuilder.Entity<Student>().Ignore(s => s.MyProperty);
 }
 ```


 ```C# 
// COMPOSITE KEY:
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
      modelBuilder.Entity<Student>().ToTable("IthsStudents", "ITHS").HasKey(s => new {s.FirstName, s.LastName});
  }
```
----------------------------------
Annotations
```C#
// Byt namn på table
[Table("MyStudents")]
public class Student
{
    public int StudentId { get; set; }

    public required string FirstName { get; set; }
    public string? LastName { get; set; }

    public DateOnly? DateOfBirth { get; set; }
}
```

* [Table("MyStudents")] är annotations, likt det som finns i JSON. (Attribut)



```C#
// Byter även SCHEMA på table(default är DBO)
[Table("MyStudents", Schema = "ITHS")]
public class Student
{
    public int StudentId { get; set; }

    public required string FirstName { get; set; }
    public string? LastName { get; set; }

    public DateOnly? DateOfBirth { get; set; }
}
```

```C#
public class Student
{
    public int StudentId { get; set; }
    // Not mapped ingorerar denna raden under
    [NotMapped]
    public int MyProperty { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }

    public DateOnly? DateOfBirth { get; set; }
}
```
* Not mapped ignorar den under texten.




## One to many

```C#
internal class RelationShipDemoContext : DbContext
{
    //public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = new SqlConnectionStringBuilder()
        {
            ServerSPN = "localhost",
            InitialCatalog = "RelationalDemo",
            TrustServerCertificate = true,
            IntegratedSecurity = true,
        }.ToString();

        optionsBuilder.UseSqlServer(connectionString);
    }
}

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; }
}

public class Student
{
    public int StudentId { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public DateOnly? DateOfBirth { get; set; }
}
```

* Använd en collection, listor eller liknande för att göra en foreign key i C#. Se course classen ovan.


## Many To Many
```C#
[DebuggerDisplay("{CourseId,nq} {Name,nq}")]
public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; }
}

[DebuggerDisplay("{StudentId,nq} {FirstName,nq} {LastName,nq}")]
public class Student
{
    public int StudentId { get; set; }

    [Required]
    public required string FirstName { get; set; }

    [Required]
    public required string LastName { get; set; }

    public DateOnly? DateOfBirth { get; set; }
    public List<Course> Courses { get; set; }

    public int CourseId { get; set; }
}
```
* listor från klasserna pekar mot varandra


## Eager/Explicit/Lazy Loading

* https://learn.microsoft.com/en-us/ef/core/querying/related-data/

------------------------
Eager Loading
* Include är basically en Join i SQL.
* ThenInclude är en nestad join.

```C#
// Include laddar in students listan
var query = db.Tracks.Include(t => t.Genre).Include(t => t.Album).ThenInclude(al => al.Artist);
```

------------------------
Explicit Loading

* Laddar specifik data som behövs.
* Collection laddar en collection, lista etc.
*  Reference laddar en annan referens.

```C#
db.Entry(albums[0]).Collection(a => a.Tracks).Load();
db.Entry(albums[1]).Reference(a => a.Artist).Load();
```