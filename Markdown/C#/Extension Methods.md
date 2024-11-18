# Extension Methods
En statiskt metod måste innehålla this för att bli en Extension method,
```C#
static class Extensions
{
    public static void Drink(this Cat cat)
    {
        Console.WriteLine($"{cat.name} is drinking")
        cat.Weight += .1;
    }
}
```

* this för att kunna "bypassa" den statiska biten.
* Kan endast använda this på den först parametern.
    ```C#
    
    public static void Drink(this Cat c1, Cat c2)
    {
        Console.WriteLine($"{c1.name} hugs {c2.name}")
     }
    ```


* Om jag instancerar ett object av säg Cat, och för en new Cat så kan jag calla en funktion från det skapade objectet, om den har en parameter this. För att referera till objektet som kallar. sen parametern skickar då in andra, katten.

## Detta gör så att man kan calla en extension method i en statisk class på en literal value. T.ex

```C#
"Hejdu".WordCount();

  public static class StringExtensions
  {
      public static int WordCount(this string s)
      {
          return s.Split(' ').Length;
      }

      public static string Encapsulate(this string s, string enclosure)
      {
          return enclosure + s + enclosure;
      }
      public static string Encapsulate(this string s, string prefix, string suffix)
      {
          return prefix + s + suffix;
      }
  }
```