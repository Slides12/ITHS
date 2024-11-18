# DateTime  and Timespan


## DateTime
### Statiska (För att komma åt nuvarande värden)
* DateTime.MaxValue (Ger max värde som är möjligt)
* DateTime.MinValue (Ger min värde som är möjligt)
* DateTime.Now (Ger datumet och tid NU)

* DateTime.UtcNow (Ger UTC tiden som är nu.)


-----------------
### Håller ett specifikt datum och tid
DateTime myDateTime = new DateTime(); (skapas på min värde)
DateTime myDateTime = DateTime.Now; (Skapas på nu värdet)


* myDateTime.Year ( Ger nurande år som int( som är satt från början dvs))
* myDateTime.Month ( Ger nurande Månad som int( som är satt från början dvs)) 
    * finns i all oändlighet, skriver inte ut allt.


* myDateTime.DayOfWeek ( ger tillbaka dagen i text)

* myDateTime.DayOfYear ( ger tillbaka dagen siffra av 365)

*  myDateTime.AddYears(5) (adderar på 5 år på datumet, finns för månader,dagar, timmar etc dessutom)

* myDateTime.Subtract(DateTime.Now) (Ger tiden mellan datumet i dagar, timmar etc)

------------------------------
## TimeSpan
TimeSpan timeSpan = new TimeSpan(); (Ren tid, med dagar, timmar, min och sek)
