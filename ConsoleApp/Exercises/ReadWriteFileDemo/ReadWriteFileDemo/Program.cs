﻿using ReadWriteFileDemo;

var movieManager = new MovieManager();

//Path.Combine används för att bygga sökvägar på ett korrekt sätt.
//I Environment kan man hitta alla standard-mappar i en windowsdator. Tex. AppData, Desktop, MyDocuments mm.
var directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "NiklasNet23");
Directory.CreateDirectory(directory);

var genres = Enum.GetValues<Genres>();

foreach (var genre in genres)
{
    var path = Path.Combine(directory, $"{genre}.txt");
    movieManager.CreateMovieFile(path, genre);
}


var sciFiPath = Path.Combine(directory, "SciFi.txt");
var sciFiMovies = movieManager.ReadMovieFile(sciFiPath);

var actionPath = Path.Combine(directory, "Action.txt");
var actionMovies = movieManager.ReadMovieFile(actionPath);

var comedyPath = Path.Combine(directory, "Comedy.txt");
var comedyMovies = movieManager.ReadMovieFile(comedyPath);

var dramaPath = Path.Combine(directory, "Drama.txt");
var dramaMovies = movieManager.ReadMovieFile(dramaPath);

var horrorPath = Path.Combine(directory, "Horror.txt");
var horrorMovies = movieManager.ReadMovieFile(horrorPath);

var thrillerPath = Path.Combine(directory, "Thriller.txt");
var thrillerMovies = movieManager.ReadMovieFile(thrillerPath);

var fantasyPath = Path.Combine(directory, "Fantasy.txt");
var fantasyMovies = movieManager.ReadMovieFile(fantasyPath);



MovieCollection pathList = new MovieCollection();





while (true) {
    Console.WriteLine($"Enter a movie genre: {genres[0]},{genres[1]},{genres[2]},{genres[3]},{genres[4]},{genres[5]},{genres[6]}");
    string userInput = Console.ReadLine();
    Console.Clear();

    if (userInput != null)
    {
            
                foreach (var movie in pathList.Movies)
                {
                        foreach(var genre in movie.Genres) 
                        { 
                            if (userInput == genre.ToString())
                            {
                                Console.WriteLine(movie);
                            break;

                            }
                        }
            
                }
    }
}



Console.WriteLine();

//HashSet<Movie> filmer = new HashSet<Movie>(new MovieEqualityComparer());