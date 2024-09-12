# Filhantering

## Sökväg
* Absolut sökväg, hela sökvägen från disk. T.ex C:\users\djoha\desktop
* Relativ sökväg, anger platsen i den aktulla katalogen. T.ex .\djoha\desktop (. anger aktuell mapp)


## Path
* Path.Combine() - Används för att bygga sökvägar, denna gör så att det fungerar på samtliga OS.
    ```
    string path = "C:\\users\\djoha";
    string newPath = Path.Combine(path, "source", "repos");
    ```
    ```
    string newPath = Path.Combine("C:", "users", "djoha", "source", "repos");
    ```

* Path.GetFullPath() - returnar den absoluta pathen. (Från current folder om det är en relativ sökväg den kollar, annars absolut. )
*  Path.GetFileName() - Skriver ut filenamnet som är specificerat.
    ```
    string newPath = Path.Combine("c:", "users", "djoha", "documents", "README.md");
    Console.WriteLine(Path.GetFileName(newPath));
    ```
    * Skriver ut README.md

* Path.GetFileNameWithoutExtension() - Skriver ut README endast
* Path.GetExtension() - Skriver ut .md endast

* Path.GetDirectoryName() - ger den absoluta sökvägen till där koden utförs.
* Path.GetPathRoot() - ger root sökvägen, i windows, C:\\.
* Path.Exists() - kollar om mappen/filen finns.


## Directory

* Directory.GetCurrentDirectory() - Ger den absoluta sökvägen där programmet körs (Där EXE filen ligger).

*  Directory.GetFiles() - hämtar namnet på alla filer i en PATH. Returnar en STRING array.

*  Directory.GetDirectoryName() - hämtar namnet på alla mappar i en PATH. Returnar en STRING array.

* Directory.CreateDirectory() - Skapa mappar, om du overloadar med fler strings så blir det en  undermappar dessutom.

* Directory.Delete() - Deletar mapp eller fil (Om mappen är tom), kan deleta hela sökvägen om man sätter true.



## File
Skapa, flytta, deleta, öppna filer etc.

## StreamWriter 
```
StreamWriter writer = new StreamWriter("myFile.txt");
```
Om jag lägger overide true, så appendar allt. Om inte skapar ny fil varje gång.
```
StreamWriter writer = new StreamWriter("myFile.txt", true);
```


* writer.WriteLine("Hej världen!") - skriver Hej världen till filen myFile.txt som jag instancerade ovan.

* writer.Dispose() - Frigör resursern, Stänger streamen tekniskt sett. (Kan inte lägga till mer i filen efter detta.)
* writer.Flush() - pushar stringen till filen.

```
using (StreamWriter writer = new StreamWriter("myFile.txt", false))
{
    for (int i = 0; i < 10; i++)
    {
        writer.WriteLine($"Hejsan världen! {i}");


    }
}
```
Koden ovan är hur man vanligtvis skriver data till fil, detta för att den automatiskt disposar när den är klar. Kan användas med allt som har en inbyggd dispose i sig.





## StreamReader 

```
using (StreamReader reader = new StreamReader("myFile.txt"))
{
    Console.WriteLine((char)reader.Read());

} 
```
Skriver ut unicode för första tecknet i filen. casta (char) innan så skriver den ut en char.

*  reader.ReadLine() - skriver ut hela först raden.


* hur man loopar i readLine:
    ```
    using (StreamReader reader = new StreamReader("myFile.txt"))
    {
        while (!reader.EndOfStream) { 
        Console.WriteLine(reader.ReadLine());
        }
    }
    ``` 
* Du behöver inte göra en while loop, Funktionen     Console.Write(reader.ReadToEnd());
    
läser ut allt.



## FileStream 
Används för att läsa/skriva binär data från/till en fil

```
using (FileStream stream = File.OpenRead("L016_FileStream.exe"))
{
    Console.WriteLine(stream.Length);
}
``` 
skriver ut längden på filen

* stream.Read(data) läser datan



Skriver ut hexadecimaler på filen som den kollar. (Går att jämföra med hexEditor)
```
using (FileStream stream = File.OpenRead("L016_FileStream.exe"))
{
    byte[] data = new byte[stream.Length];


    Console.WriteLine(stream.Read(data));


    for (int i = 0; i < 100; i++)
    {
        Console.Write(data[i].ToString("X2")+" ");
    }

}
```


