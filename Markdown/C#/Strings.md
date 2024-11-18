# Strings

Går att indexera. De fungerar som en read-only array av char.




## loop genom en string value

```
string myString = "Hello world";

Console.WriteLine(myString.Length);


for (int i = 0; i < myString.Length; i++)
{
    Console.WriteLine(myString[i]);
}

foreach (char letter in myString)
{
    Console.WriteLine(letter);
}
```

# Char

använder single '' string använder ""

#Escape character
* \ <- (kallas literal string)är reserverad i strings för t.ex \n
för att kunna t.ex skriva ut en \ så måste koden vara 2 "\\" för att bli korrekt. den första tar ut den reserverade delen. funkar med andra också.

```
Console.WriteLine("Hello \\world! ");
```

* @ (kallas verbatim string literal. overridar \ t.exm dvs tar bort den reserverande biten. Gammalt sätt.)


* $ (Kallas interpolation string) (Injektar variablar eller literal values inom måsvinge)
```
Console.WriteLine($"Hello {77*2} world! ");
```
