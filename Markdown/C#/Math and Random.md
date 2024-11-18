# Math and Random

## Math
* Math används på Double

* MathF används på float


* Math.PI = returnar PI
* Math.E = returnar E (Ingen aning vad E är)
* Math.Tau = returnar Tau(Dubbla pi va?)
* Math.Abs(-5) = gör minus tal till positiva.
* Math.Floor(5.23) (Avrundar till heltal neråt)
* Math.Celing(5.23) (Avrundar till heltal uppåt)
* Math.Round(5.23) (Avrundar till som vanligt, dvs under .5 neråt över uppåt)
* Math.Truncate(5.23) (Tar bort decimalerna)
* Math.Min(5.23,6.07) ( returnar det minsta talet)
* Math.Max(5.23,6.07) ( returnar det största talet)
* Math.Clamp(5.23,6.07,9.3) (returnerar talen imellan 5.23 och 9.3 allt annat blir antingen 5.23 eller 9.3)

* Math.Pow(3,3) = 3 upphöjt till 3 (3*3*3 = 27)

* Math.Sqrt(9) = squareroot (roten ur), så 3 är svaret på roten ur 9




## Random
### Random rnd = new Random();

* rnd.Next() ( tar 3 overloads för att göra  ett random nummber mellan x och y eller endast en maxgräns. Callar du utan någon siffra i så får du ett random heltal på max int32.MaxValue)

* rnd.NextDouble() = Returnerar at random floating point number between 0-1
 
