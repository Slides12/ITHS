
using L009_Logging_and_Tracking.Model;
using Microsoft.EntityFrameworkCore;


//AddCountry("Spain");
//UpdateDemo();

//RecreateDatabase();

//AddCity("Stockholm", "Sweden");
//AddCity("GothenBurg", "Sweden");
//AddCity("Oslo", "Norway");
//AddCity("Alingsås", "Sweden");
//AddCity("Borås", "Sweden");

//RemoveCity("Alingsås");



Country myCountry = GetCountry("Sweden");

SaveCountry(myCountry);

Console.WriteLine();
static void RecreateDatabase()
{
    using var db = new DemoContext();
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
}


static Country? GetCountry(string countryName)
{
    using var db = new DemoContext();

    return db.Countries.Include(c => c.Cities).FirstOrDefault(c => c.Name == countryName);
}


static void SaveCountry(Country country)
{
    using var db = new DemoContext();

    db.Countries.Update(country);
    db.PrintChangeTrackerDebugInfo("Tracking info on new dbcontext:");

    db.SaveChanges();
}

static void AddCountry(string name)
{
    using var db = new DemoContext();

    var country = new Country() { Name = name };
    
    db.Countries.Add(country);
    
    db.SaveChanges();
}


static void AddCity(string cityName, string countryName)
{
    using var db = new DemoContext();

    if(db.Cities.Any(c => c.Name == cityName))
    {
        return;
    }

    var city = new City() { Name = cityName };

    var country = db.Countries.Include(c => c.Cities).FirstOrDefault(c => c.Name == countryName) 
        ?? new Country() {Name = countryName };
    
    city.Country = country;

    db.Cities.Add(city);
    db.PrintChangeTrackerDebugInfo();

    db.SaveChanges();

}

static void RemoveCity(string cityName)
{
    using var db = new DemoContext();

    var city = db.Cities.FirstOrDefault(c => c.Name == cityName);

    if(city != null)
    db.Cities.Remove(city);

    db.PrintChangeTrackerDebugInfo();
    db.SaveChanges();
}

static void UpdateDemo()
{
    using var db = new DemoContext();

    var countries = db.Countries.ToList();

    db.PrintChangeTrackerDebugInfo("Tracker status after loading data: ");

    countries[0].Name = "Sweden?";
    countries[3].Name = "Spain?";

    db.Countries.Remove(countries[2]);

    db.PrintChangeTrackerDebugInfo("Tracker status after updates: ");

    db.SaveChanges();

    db.PrintChangeTrackerDebugInfo("Tracker status after Save: ");

}