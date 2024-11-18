# Metoder / Funktioner

* Funktioner är fristående
* Metoder är kopplade mot objekt


### Console.WriteLine();
* Console = Class.
* WriteLine = metod.


### Klasser och Objekt kan ha olika typer av "members".
1. metoder = Kodsom körs när man anropar metoden.
    * string myString.(Här visas metoden för typen av strings, går att göra för alla)


2. Properties = En "Variabel" som är kopplad till ett objekt.
    * Properties = skiftnyckel (t.ex Lenght eller this.)


### Funktioner / metoder
* DRY = Dont repeat yourself

----------------------
## .net använder en call stack för att hålla reda på varifrån olika funktioner/metoder anropas


### Call Stack = En stack med tallrikar, du lägger tallriken på toppen. Men du tar även alltid den översta. En stack skriver alltid senaste värdet till toppen(Slutet) av stacken och plockar alltid bort(Läser) alltid från toppen(Slutet).



### Funktions uppbyggnad
* static = kan ej använda globala 
variabler (Fristående, ej beroende av annan kod)

* Void = returnerar inget värde.

* Data typ istället för void returnerar den datatypen som är sagd. (return "hej";)

* En Funktion kan ta 0,1 eller flera parametrar. Varje parameter har en egen datatyp.
    * Parameter är (int x) i funktionen

* Vid funktion anrop måste argumenten stämma i antal och datatyp med funktionens parametrar.
    * Argument är när man kallar en funktion, så passar man in ett argument t.ex MyFuntion(x); x är då i detta fall ett argument.

* Används för att upprepa kod dvs. (DRY)

* Kallas Signatur: 
```
static void Greet(string namn, int gånger = 1)
```

### Default value.
* T.ex MinFunktion(int x  = 1, string gg = "")




## Params
* gör att man kan skicka in fler av samma datatyp in i en funktion/method

* Alla måste vara samma datatyp.

* Params måste ligga i den sista difinierade parametern. ex:
    ```
    static void PrintStrings(int x,params string[] strings)
    ```
* Tolkas som en array av en specifik datatyp.

## Rekursiva anrop
* Funktioner som kallar sig själv eller andra funktioner som ropar på varandra.
    * kan leda till stack overflow





## Riktlinjer för att skriva tydlig kod

Kod är främst kommunikation med andra människor.

"Make reading easy, even if it makes writing harder."

"Later equals never."

"There is nothing as permanent as a temporary solution."

### DRY - "Don't repeat yourself."
Man vill undvika upprepad kod. Om man upptäcker att man har samma kod upprepad om och om igen, flytta ut den i funktioner t.ex.

### Kommentar i kod
Kod ska i största möjliga mål vara självförklarande.

Kommentarer bör endast förklara varför, inte hur.

### Namngivning
Att ge tydliga och beskrivande namn på variabler, metoder, funktioner, klasser etc, är en av de viktigaste sakerna man kan göra för att göra koden mer lättläst.