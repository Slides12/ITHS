# Statement, Sats
#### t.e.x, declaring variables, assigning values, calling methods, looping through collections etc

* Console.WriteLine();


# Expressions, Uttryck
* 5+3,x == 5



# Variabler och datatyper
* int myInt = 0;

* double myDouble = 0.00; //Dubbel precision
* bool myBool = false; //Boolean, kan lagra true / false
* string myString = "Hello world!"; // Lagrar sträng(text)
* char myChar = 'D'; // Lagrar enskilt tecken
* Signed kan gå negativt
* Unsigned kan inte gå negativt
* suffix (Tillägg efter ett literal value för att hinta för kompilatorn vilken datatyp det är )
    * Long (l)
    * Float (f)
    * Decimal (m)



# Literal value (ett exakt/hårdkodat värde)
* "Hello world!"
* 5.3
* true



# Null värde (Keyword null, pekar en variabel mot ingenting)
* myString = null;


# C# är ett statiskt typat språk (Statically typed language)
* kan inte ändra variabler till en annan, ish, om x är int så kan jag inte ge den en string som "hallå"

* Dynamiskt är att du kan göra det
* C# är ett starkt typat språk (Strongly typed language). Kan inte ändras efterhand


* C# är ett typsäkert språk. T.ex:
    * Console.WriteLine(3+5); // + betyder addition när man gör det mellan heltal
    * Console.WriteLine("3" + "50"); // +  betyder concatenate om det är strängar
    * Console.WriteLine("Hello world".ToUpper());
    * Console.WriteLine(523.ToUpper()); - fungerar ej





# Explicit (utryckligen) och implicit (underförstått) typade variabler
* Keyword: var
* Oavsett vilket (implicit eller explicit) så är c# typat, den måste veta data typen vid compile-time. Använder du var så säger du till kompilatorn att själv lista ut vad du menar.

* var myVariable = 5 || var myVariable = "hej";
* var blir deklarerat vid kompilation och kan ej ändras när det körs. Så om jag sätter var till string kan jag ej ändra denna till int senare.


# Scope -  ( livdstid på en variabel) HUr länge är den giltlig.
* Class level scope
* Method level scope
* Block level scope
*Top level scope ( utanför function i klass)
    * int =0;

*   ```
    IF(3 < 5){
    int i = 0; (Sub/Low/nested level scope)
    }
    ```



# Operators
* int x = 5 +(<-Operator) 5(<-operands);
* Plus(+)

* Minus(-)
* Gånger (*)
* Division(/)
* Remainder(%)
* addera med en (++) (Skriv efter en variabel och den läser OG-tal först, sen lägger till/tar bort. Sätt den innan variabeln, och det första den gör är att addera/Subtrahera)
    ```
    Console.Writeline(++int) (Innan)
    Console.Writeline(int--) (Efter)
    ```
* subtrahera med en (--)

* Increase by X (+=, -=, *=, /=, %=)
    * x +=5; 
    * x -=5;
    * x *=5; 
    * x /=5; 
    * x %=5; 





# Assignment Operators && Equality operators
* Lika med (=)
* Equals (==) (True/False)
* Not equals to (!=) (True/False)


# Comparison operators

* Mindre än (<)
* Större än (>)
* Mindre än eller lika med (<=)
* Större än eller lika med (>=)

# Logiska operators (Bool)

* not (!) (!true)
* and (&&) (används för att kolla om flera uttryck blir true. Eller false)
* Or (||) (används för att kolla om antingen första eller nästa kommande blir true eller false)


