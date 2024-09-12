Console.WriteLine("*********PATH************");

string path = "C:\\users\\djoha";

string newPath = Path.Combine("c:", "users", "djoha", "documents");

Console.WriteLine(newPath);



Console.WriteLine(Path.GetFullPath(newPath));
Console.WriteLine(Path.GetFileName(newPath));
Console.WriteLine(Path.GetFileNameWithoutExtension(newPath));
Console.WriteLine(Path.GetExtension(newPath));
Console.WriteLine(Path.GetDirectoryName(newPath));
Console.WriteLine(Path.GetPathRoot(newPath));


Console.WriteLine(Path.Exists(newPath));
Console.WriteLine();
Console.WriteLine("*********Directory************");


Console.WriteLine(Directory.GetCurrentDirectory());
string[] fileNames = Directory.GetFiles(Path.GetDirectoryName(newPath));


foreach(string file in fileNames)
{
    Console.WriteLine(Path.GetFileName(file));
}



string[] directories = Directory.GetDirectories(Path.GetDirectoryName(newPath));


foreach (string file in directories)
{
    Console.WriteLine(Path.GetFileName(file));
}


string newFolder = Path.Combine(newPath, "NewFolder", "Test1");

Directory.CreateDirectory(newFolder);


Directory.Delete(newFolder);


