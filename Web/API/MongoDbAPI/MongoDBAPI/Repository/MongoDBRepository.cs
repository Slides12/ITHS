using MongoDB.Bson;
using MongoDB.Driver;
using API.Models;
using MongoDB.Driver.Linq;
namespace API.Repository;

public class MongoDBRepository
{

    private readonly IMongoCollection<Product> _productCollection;

    public MongoDBRepository(IConfiguration configuration)
    {
        var config = new ConfigurationBuilder().AddUserSecrets<MongoDBRepository>().Build();
        var connectionString = config["ConnectionString"]; 
        var mongoClient = new MongoClient(connectionString);
        var database = mongoClient.GetDatabase("Rest-API");

        _productCollection = database.GetCollection<Product>("Product");
    }

    public async Task<List<Product>> GetProductsFromMONGO()
    {
        var list = await _productCollection.
            AsQueryable()
            .ToListAsync();

        return list;
    }

    public async Task<List<Product>> GetAProductFromMONGObyID(ObjectId id)
    {
        var list = await _productCollection
            .Find(p => p.Id == id)
            .ToListAsync();

        return list;
    }

    public async Task<List<Product>> GetAProductFromMONGObyName(string name)
    {
        var list = await _productCollection
            .Find(p => p.Name == name)
            .ToListAsync();

        return list;
    }


    public async Task AddProductFromMONGO(Product product)
    {
        await _productCollection.InsertOneAsync(product);
    }


    public async Task UpdateProductFromMONGO(Product product, ObjectId id)
    {
        var updateDefinition = Builders<Product>.Update
      .Set(p => p.Name, product.Name)
      .Set(p => p.Description, product.Description)
      .Set(p => p.Price, product.Price)
      .Set(p => p.ProductCategory, product.ProductCategory)
      .Set(p => p.Status, product.Status);

        await _productCollection.UpdateOneAsync(
            p => p.Id == id,
            updateDefinition
        );
    }

    public async Task DeleteProductFromMONGObyID(ObjectId id)
    {
        var filter = Builders<Product>.Filter
        .Eq(p => p.Id, id);

        await _productCollection.DeleteOneAsync(filter);

    }

        public async Task DeleteProductFromMONGObyName(string name)
    {
        var filter = Builders<Product>.Filter
        .Eq(p => p.Name, name);

        await _productCollection.DeleteManyAsync(filter);
    }

}
