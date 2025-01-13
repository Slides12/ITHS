

using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;

var doc = new BsonDocument {
    { "FirstName", "Fredrik" },
    { "LastName", "Johansson" },
    { "Contacts", new BsonDocument{
        { "Phone", "0917230709123" },
        { "Email", "fredrik@gmail.com" }
    } },
    { "List", new BsonArray{
        1,
        5,
        123,
        "Hej",
        2,
        new BsonDocument{
            { "Key", "value" }
        }
    }},
};


doc.Add("Color", "Blue");
doc.Set("FirstName", "Kalle");


doc.Remove("LastName");

doc["FirstName"] = "Pelle";

//Console.WriteLine(doc["FirstName"]);


var jsonSettings = new JsonWriterSettings { Indent = true };

//Console.WriteLine(doc.ToJson(jsonSettings));

////Console.WriteLine($"\n Firstname = {doc["FirstName"]}");

//Console.WriteLine();
//Console.Write("Enter Key: ");
//var myKey = Console.ReadLine();

//if (doc.TryGetValue(myKey, out BsonValue myValue))
//{
//    Console.WriteLine($"\n{myValue.ToString()}");
//}
//else
//{
//    Console.WriteLine($"Key {myKey} does not exist.");
//}


var connectionString = "mongodb+srv://admin:admin@iths.jrmip.mongodb.net/";

var client = new MongoClient(connectionString);

//var myCollection = client.GetDatabase("iths").GetCollection<BsonDocument>("MyCollection");

//myCollection.InsertOne(doc);


var movieCollection = client.GetDatabase("sample_mflix").GetCollection<BsonDocument>("movies");

var filter = Builders<BsonDocument>.Filter.Regex("title", "/matrix/i");

var projection = Builders<BsonDocument>.Projection
    .Include("title")
    .Include("year")
    .Include("plot")
    .Include("imdb.rating")
    .Exclude("_id");

//var movie = movieCollection.Find(filter).Project(projection).FirstOrDefault();


//Console.WriteLine(movie.ToJson(jsonSettings));


var movies = movieCollection.AsQueryable().Where(m => m["title"].ToString().ToLower().Contains("matrix")).ToList();


movies.ForEach(m => Console.WriteLine($"{m["title"]}"));
