

using MongoDB.Bson;
using MongoDB.Bson.IO;

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

Console.WriteLine(doc["FirstName"]);


var jsonSettings = new JsonWriterSettings { Indent = true };

Console.WriteLine(doc.ToJson(jsonSettings));

//Console.WriteLine($"\n Firstname = {doc["FirstName"]}");

Console.WriteLine();
Console.Write("Enter Key: ");
var myKey = Console.ReadLine();

if (doc.TryGetValue(myKey, out BsonValue myValue))
{
    Console.WriteLine($"\n{myValue.ToString()}");
}
else
{
    Console.WriteLine($"Key {myKey} does not exist.");
}
