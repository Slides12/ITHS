﻿namespace ReadWriteFileDemo;

public class MovieManager
{
    public MovieCollection MovieDb { get; set; } = new MovieCollection();

    public void CreateMovieFile(string path)
    {
        //File.Exists kan användas för att kontrollera ifall en fil finns på en given sökväg
        if (!File.Exists(path))
        {
            //StreamWriter används för att öppna en fil och skriva till den.
            //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
            using StreamWriter sw = new StreamWriter(path);
            foreach (var movie in MovieDb.Movies)
            {
                //WriteLine används för att skriva en ny rad.
                sw.WriteLine(movie);
            }
            sw.Close();
        }
    }

    public void CreateMovieFile(string path, Genres genre)
    {
        //File.Exists kan användas för att kontrollera ifall en fil finns på en given sökväg
        if (!File.Exists(path))
        {
            var genreMovies = MovieDb.Movies
                    .Where(m => m.Genres.Any(g => g == genre));

            //StreamWriter används för att öppna en fil och skriva till den.
            //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
            using StreamWriter sw = new StreamWriter(path);
            foreach (var movie in genreMovies)
            {
                //WriteLine används för att skriva en ny rad.
                sw.WriteLine(movie);
            }
            sw.Close();
        }
    }

    public List<Movie> ReadMovieFile(string path)
    {
        if (!File.Exists(path))
        {
            return new List<Movie>();
        }

        List<Movie> movieList = new List<Movie>();
        string? line = "";

        string title = "";
        string length = "";
        string description = "";
        string genres = "";

        //StreamReader används för att öppna en fil och läsa från den.
        //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
        using StreamReader sr = new StreamReader(path);
        //ReadLine() läser nästa rad i filen
        while ((line = sr.ReadLine()) != null)
        {
            if (line.StartsWith("Title: "))
            {
                title = line.Substring(7);
            }
            else if (line.StartsWith("Length: "))
            {
                length = line.Substring(8);
            }
            else if (line.StartsWith("Description: "))
            {
                description = line.Substring(13);
            }
            else if (line.StartsWith("Genres: "))
            {
                genres = line.Substring(8);
            }
            else
            {
                Movie tempMovie = new Movie();
                tempMovie.Title = title;
                tempMovie.Description = description;

                string lengthText = length.Split(' ')[0];
                tempMovie.Length = double.Parse(lengthText);

                string[] genresText = genres.Split(',');
                List<Genres> genresList = new List<Genres>();
                foreach (var genre in genresText)
                {
                    if (genre == "")
                    {
                        break;
                    }

                    genresList.Add(Enum.Parse<Genres>(genre));
                }

                tempMovie.Genres = genresList;
                movieList.Add(tempMovie);
            }
        }

        return movieList;
    }
}