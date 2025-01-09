

using L013_RepositoryPattern.Repository;
using L013_RepositoryPattern.Model;

using (var unitOfWork = new UnitOfWork(new MovieContext()))
{
    //Movie? myMovie = unitOfWork.Movies.Find(m => m.Title == "The Italian").FirstOrDefault();

    Movie myMovie = unitOfWork.Movies.Get("573a1390f29313caabcd446f");

    if(myMovie is not null)
    {
        Console.WriteLine($"{myMovie.Title} was created {myMovie.Year}");
    }
    else
    {
        Console.WriteLine("Movie not found!");
    }

    var topMovies = unitOfWork.Movies.GetTopRatedMovies(5,2001);

}