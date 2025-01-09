using L005_ScaffoldedMusic.Model;

using L005_ScaffoldedMusic;
using Microsoft.EntityFrameworkCore;

using var db = new EveryloopContext();

//var query = db.Tracks
//    .Include(t => t.Genre)
//    .Include(t => t.Album)
//    .ThenInclude(al => al.Artist);

//Console.WriteLine(query.ToQueryString());

//var tracks = query.ToList();




var albums = db.Albums.ToList();

db.Entry(albums[0]).Collection(a => a.Tracks).Load();
db.Entry(albums[1]).Reference(a => a.Artist).Load();




Console.WriteLine();