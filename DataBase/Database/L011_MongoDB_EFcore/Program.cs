using L011_MongoDB_EFcore.Model;




using (var db = new MongoDBContext())
{

    var myMovie = db.Movies.FirstOrDefault();



    Console.WriteLine(myMovie.Title);


    //myMovie.Title += "_X";

    //db.SaveChanges();

}