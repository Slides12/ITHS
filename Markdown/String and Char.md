# String and Char

## String

* string myString = string.Empty; == string myString = "";
* myString.PadLeft(50,'*') (Gör en ny string exakt 50 tecken, inkluderat * och eventuell text i myString)

* myString.PadRight(50,'*') (Finns också, dom overrider inte OG stringen)

* myString.Substring(4,3) (skriver ut myString från startvärde, sen overload 2 gör att den tar från  4an i detta fallet, 3 karaktärer framåt och pringar detta. INgen override.)


* myString.Remove(4,3) (tar bort det som Substring skulle ha printat. men printar det som är kvar. Overridar inte.)

* myString.Replace("World", "there") (Byter ord till annat, eller chars.)

* myString.Insert(4, "abc") ( sätter in "abc" på index 4 )

* myString.IndexOf('o') ( returnerar första värdet som en INT med indexPlatsen, fungerar på string också. "-1" betyder att det inte finns)

* myString.IndexOfLast('o') ( returnerar sista värdet som en INT med indexPlatsen, fungerar på string också. "-1" betyder att det inte finns)



## Char

* Char.IsDigit(myChar) (kollar om värdet myChar är en siffra. Returnerar ett bool värde.)

* Char.IsLetter(myChar) (kollar om värdet myChar är en bokstav. Returnerar ett bool värde.)

* Char.IsLetterOrDigit(myChar) (kollar om värdet är antingen bokstav eller siffra, ger true på både bokstav och siffra. Ger false på allt annat.)

* Char.IsUpper(myChar) ( Kollar om det är en stor eller liten bokstav. Ger true på stora.)

* Char.IsLower(myChar) ( Kollar om det är en stor eller liten bokstav. Ger true på små.)

* Char.WhiteSpace(myChar) ( Kollar om det är en mellanslag.)