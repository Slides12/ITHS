using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Models;

public class Product
{
    [BsonId]
    public ObjectId Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ProductCategory { get; set; }
    public bool Status { get; set; }
}
