using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace L013_RepositoryPattern.Model;

class IMDB()
{
    [BsonElement("rating")]
    public double Rating { get; set; }
    
    [BsonElement("votes")]
    public int Votes { get; set; }
    
    [BsonElement("id")]
    public int Id { get; set; }

}