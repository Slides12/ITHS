using MongoDB.Bson;
using MongoDB.Driver;




var connectionString = "mongodb+srv://admin:admin@iths.jrmip.mongodb.net/";

var client = new MongoClient(connectionString);

var movieCollection = client.GetDatabase("newDb").GetCollection<Movie>("movies");


var movies = movieCollection.AsQueryable().ToList();


foreach (var movie in movies)
{
    Console.WriteLine($"{movie.Title} ({movie.Year})");
}

Task changeStream = ChangeStream(movieCollection, movies);

await changeStream;

static async Task ChangeStream(IMongoCollection<Movie> collection, List<Movie> movies)
{
    var changeStreamOptions = new ChangeStreamOptions()
    {
        FullDocument = ChangeStreamFullDocumentOption.UpdateLookup
    };
   
    var pipeline = new EmptyPipelineDefinition<ChangeStreamDocument<Movie>>()
        .Match(change => change.OperationType == ChangeStreamOperationType.Update);

    using var cursor = await collection.WatchAsync(/*pipeline,*/ changeStreamOptions);



    await cursor.ForEachAsync(change =>
    {
            var movieId = change.DocumentKey.GetValue("_id");
            var movie = change.FullDocument;
            var existingMovieWithSameId = movies.Where(m => m.Id == movieId).FirstOrDefault();

        if(change.OperationType == ChangeStreamOperationType.Insert)
        {
            Console.WriteLine($"{movie.Title} ({movie.Year})");
        }
        else if(change.OperationType == ChangeStreamOperationType.Update)
        {
            existingMovieWithSameId.Title = movie.Title;
            existingMovieWithSameId.Year = movie.Year;

            var index = movies.IndexOf(existingMovieWithSameId);

            var oldCursorPosition = Console.GetCursorPosition();

            Console.SetCursorPosition(0, index);
            Console.WriteLine($"{movie.Title} ({movie.Year})".PadRight(100));

            Console.SetCursorPosition(oldCursorPosition.Left, oldCursorPosition.Top);

        }
        else if(change.OperationType == ChangeStreamOperationType.Delete)
        {


            movies.Remove(existingMovieWithSameId);

            Console.Clear();


            foreach (var m in movies)
            {
                Console.WriteLine($"{m.Title} ({m.Year})");
            }
        }

    });

}


class Movie()
{
    public ObjectId Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
}