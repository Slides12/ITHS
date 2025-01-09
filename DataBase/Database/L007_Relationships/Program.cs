
using L007_Relationships.Model;
using Microsoft.EntityFrameworkCore;


using var db = new RelationShipDemoContext();

db.Database.EnsureDeleted();
db.Database.EnsureCreated();


var query = db.Courses.Include(c => c.Students);

var courses = query.ToList();

Console.WriteLine(query.ToQueryString());
Console.WriteLine();

